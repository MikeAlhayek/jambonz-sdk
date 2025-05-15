using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class ServiceProvidersService : ApiBaseService, IServiceProvidersService
{
    public ServiceProvidersService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/ServiceProviders", httpClientFactory, options)
    {
    }

    public Task<PagedResult<CallLogEntry>> GetRecentCallsAsync(string providerId, CallLogQueryContext context, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);
        ArgumentNullException.ThrowIfNull(context);

        var queryParameters = new Dictionary<string, string>
        {
            { "page", ParameterToString(context.Page) },
            { "count", ParameterToString(context.Count) },
            { "days", ParameterToString(context.Days) },
        };

        if (context.Start.HasValue)
        {
            queryParameters.Add("start", ParameterToString(context.Start.Value));
        }

        if (context.End.HasValue)
        {
            queryParameters.Add("end", ParameterToString(context.End.Value));
        }

        if (context.Answered.HasValue)
        {
            queryParameters.Add("end", ParameterToString(context.End.Value));
        }

        if (context.Direction.HasValue)
        {
            queryParameters.Add("direction", ParameterToString(context.Direction.Value));
        }

        if (!string.IsNullOrEmpty(context.Filter))
        {
            queryParameters.Add("filter", ParameterToString(context.Filter));
        }

        var uri = QueryHelpers.AddQueryString($"{UriPrefix}/{providerId}/RecentCalls", queryParameters);

        return GetByUriAsync<PagedResult<CallLogEntry>>(uri, cancellationToken);
    }

    public Task<CallTrace> GetCallTraceAsync(string providerId, string callId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);
        ArgumentException.ThrowIfNullOrEmpty(callId);

        return GetByUriAsync<CallTrace>($"{UriPrefix}/{providerId}/RecentCalls/trace/{callId}", cancellationToken);
    }

    public Task<CallTrace> GetCallPcapAsync(string providerId, string callId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);
        ArgumentException.ThrowIfNullOrEmpty(callId);

        return GetByUriAsync<CallTrace>($"{UriPrefix}/{providerId}/RecentCalls/{callId}/pcap", cancellationToken);
    }
}
