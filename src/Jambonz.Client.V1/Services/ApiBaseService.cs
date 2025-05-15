using System.Net.Http.Json;
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

    protected HttpClient GetClient()
        => HttpClientFactory.CreateClient(JambonzConstants.HttpClientName);

    protected async Task<TResult> GetRecordAsync<TResult>(string id, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        var client = HttpClientFactory.CreateClient(JambonzConstants.HttpClientName);

        var response = await client.GetAsync($"{UriPrefix}/{id}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TResult>(Options.JsonSerializerOptions, cancellationToken);
    }

    protected async Task<TResult> GetRecordsAsync<TResult>(CancellationToken cancellationToken = default)
    {
        var client = HttpClientFactory.CreateClient(JambonzConstants.HttpClientName);

        var response = await client.GetAsync(UriPrefix, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TResult>(Options.JsonSerializerOptions, cancellationToken);
    }

    protected async Task<TResult> CreateRecordAsync<TData, TResult>(TData data, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(data);

        var client = HttpClientFactory.CreateClient(JambonzConstants.HttpClientName);

        var response = await client.PostAsJsonAsync(UriPrefix, data, Options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TResult>(Options.JsonSerializerOptions, cancellationToken);
    }

    protected async Task<bool> CreateRecordAsync<TData>(TData data, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(data);

        var client = HttpClientFactory.CreateClient(JambonzConstants.HttpClientName);

        var response = await client.PostAsJsonAsync(UriPrefix, data, Options.JsonSerializerOptions, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    protected async Task<bool> UpdateRecordAsync<TData>(string id, TData data, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(id);
        ArgumentNullException.ThrowIfNull(data);

        var client = HttpClientFactory.CreateClient(JambonzConstants.HttpClientName);

        var response = await client.PutAsJsonAsync($"{UriPrefix}/{id}", data, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    protected async Task<bool> DeleteRecordAsync(string id, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        var client = HttpClientFactory.CreateClient(JambonzConstants.HttpClientName);

        var response = await client.DeleteAsync($"{UriPrefix}/{id}", cancellationToken);

        return response.IsSuccessStatusCode;
    }
}
