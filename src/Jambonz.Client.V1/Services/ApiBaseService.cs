using System.Collections;
using System.Net.Http.Json;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using Jambonz.Client.Core.Json;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public abstract class ApiBaseService
{
    protected readonly string UriPrefix;
    protected readonly IHttpClientFactory HttpClientFactory;
    protected readonly JambonzJsonSerializerOptions Options;

    public ApiBaseService(
        string uriPrefix,
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
    {
        UriPrefix = uriPrefix.Trim('/');
        HttpClientFactory = httpClientFactory;
        Options = options.Value;
    }

    protected HttpClient GetHttpClient()
        => HttpClientFactory.CreateClient(JambonzConstants.HttpClientName);

    protected async Task<TResult> GetByUriAsync<TResult>(string uri, CancellationToken cancellationToken = default)
    {
        var client = HttpClientFactory.CreateClient(JambonzConstants.HttpClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TResult>(Options.JsonSerializerOptions, cancellationToken);
    }

    protected async Task<TResult> PostByUriAsync<TData, TResult>(string uri, TData data, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(data);

        var client = HttpClientFactory.CreateClient(JambonzConstants.HttpClientName);

        var response = await client.PostAsJsonAsync(uri, data, Options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TResult>(Options.JsonSerializerOptions, cancellationToken);
    }

    protected async Task<bool> PostByUriAsync<TData>(string uri, TData data, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(data);

        var client = HttpClientFactory.CreateClient(JambonzConstants.HttpClientName);

        var response = await client.PostAsJsonAsync(uri, data, Options.JsonSerializerOptions, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    protected async Task<bool> PutByUriAsync<TData>(string uri, TData data, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(data);

        var client = HttpClientFactory.CreateClient(JambonzConstants.HttpClientName);

        var response = await client.PutAsJsonAsync(uri, data, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    protected async Task<bool> DeleteByUriAsync(string uri, CancellationToken cancellationToken = default)
    {
        var client = HttpClientFactory.CreateClient(JambonzConstants.HttpClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    protected Task<TResult> GetRecordAsync<TResult>(string id, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        return GetByUriAsync<TResult>($"{UriPrefix}/{id}", cancellationToken);
    }

    protected Task<TResult> GetRecordsAsync<TResult>(CancellationToken cancellationToken = default)
        => GetByUriAsync<TResult>(UriPrefix, cancellationToken);

    protected Task<TResult> CreateRecordAsync<TData, TResult>(TData data, CancellationToken cancellationToken = default)
        => PostByUriAsync<TData, TResult>(UriPrefix, data, cancellationToken);

    protected Task<bool> CreateRecordAsync<TData>(TData data, CancellationToken cancellationToken = default)
        => PostByUriAsync(UriPrefix, data, cancellationToken);

    protected Task<bool> UpdateRecordAsync<TData>(string id, TData data, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        return PutByUriAsync($"{UriPrefix}/{id}", data, cancellationToken);
    }

    protected Task<bool> DeleteRecordAsync(string id, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        return DeleteByUriAsync($"{UriPrefix}/{id}", cancellationToken);
    }

    protected static string ParameterToString(object obj)
    {
        if (obj is DateTime dateTime)
        {
            return dateTime.ToString("o");
        }

        if (obj is DateTimeOffset offset)
        {
            return offset.ToString("O");
        }

        if (obj is Enum enm)
        {
            return GetEnumMemberValue(enm);
        }

        if (obj is IEnumerable items)
        {
            var flattenedString = new StringBuilder();

            foreach (var param in items)
            {
                if (flattenedString.Length > 0)
                {
                    flattenedString.Append(',');
                }

                flattenedString.Append(param);
            }

            return flattenedString.ToString();
        }

        if (obj is bool b)
        {
            return Convert.ToString(obj).ToLowerInvariant();
        }

        return Convert.ToString(obj);
    }

    protected static string GetEnumMemberValue<T>(T enumValue)
        where T : Enum
    {
        var type = typeof(T);
        var member = type.GetMember(enumValue.ToString()).FirstOrDefault();

        if (member != null)
        {
            var attribute = member.GetCustomAttribute<EnumMemberAttribute>();
            if (attribute != null)
            {
                return attribute.Value;
            }
        }

        return enumValue.ToString();
    }
}
