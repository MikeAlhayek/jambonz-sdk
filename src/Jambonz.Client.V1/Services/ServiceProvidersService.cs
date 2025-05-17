using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.Accounts;
using Jambonz.Client.V1.Models.Calls;
using Jambonz.Client.V1.Models.LeastCostRoutings;
using Jambonz.Client.V1.Models.ServiceProviders;
using Jambonz.Client.V1.Models.VoipCarriers;
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

    /// <inheritdoc />
    public Task<ServiceProvider> GetAsync(string providerId, CancellationToken cancellationToken = default)
        => GetRecordAsync<ServiceProvider>(providerId, cancellationToken);

    /// <inheritdoc />
    public Task<bool> CreateAsync(CreateServiceProvider data, CancellationToken cancellationToken = default)
        => CreateRecordAsync(data, cancellationToken);

    /// <inheritdoc />
    public Task UpdateAsync(string providerId, UpdateServiceProvider data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(providerId, data, cancellationToken);

    /// <inheritdoc />
    public Task<bool> DeleteAsync(string providerId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(providerId, cancellationToken);

    /// <inheritdoc />
    public Task<Account[]> GetAccountsAsync(string providerId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);

        return GetByUriAsync<Account[]>($"{UriPrefix}/{providerId}/Accounts", cancellationToken);
    }

    /// <inheritdoc />
    public Task<AccountLimitResult[]> ListLimitsAsync(string providerId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);

        return GetByUriAsync<AccountLimitResult[]>($"{UriPrefix}/{providerId}/Limits", cancellationToken);
    }

    /// <inheritdoc />
    public Task<VoipCarrier[]> ListCarriersAsync(string providerId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);

        return GetByUriAsync<VoipCarrier[]>($"{UriPrefix}/{providerId}/VoipCarriers", cancellationToken);
    }

    /// <inheritdoc />
    public Task<CreatedCarrier> CreateCarrierAsync(string providerId, CreateServiceProviderCarrier data, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);

        return PostByUriAsync<CreateServiceProviderCarrier, CreatedCarrier>($"{UriPrefix}/{providerId}/VoipCarriers", data, cancellationToken);
    }

    /// <inheritdoc />
    public Task<CreatedCarrier> AddCarrierAsync(string providerId, string carrierId, CreateServiceProviderCarrier data, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);
        ArgumentException.ThrowIfNullOrEmpty(carrierId);

        return PostByUriAsync<CreateServiceProviderCarrier, CreatedCarrier>($"{UriPrefix}/{providerId}/PredefinedCarriers/{carrierId}", data, cancellationToken);
    }

    /// <inheritdoc />
    public Task<PagedResult<CallLogEntry>> PageRecentCallsAsync(string providerId, CallLogQueryContext context, CancellationToken cancellationToken = default)
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

    /// <inheritdoc />
    public Task<CallTrace> GetCallTraceAsync(string providerId, string callId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);
        ArgumentException.ThrowIfNullOrEmpty(callId);

        return GetByUriAsync<CallTrace>($"{UriPrefix}/{providerId}/RecentCalls/trace/{callId}", cancellationToken);
    }

    /// <inheritdoc />
    public Task<CallTrace> GetCallPcapAsync(string providerId, string callId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);
        ArgumentException.ThrowIfNullOrEmpty(callId);

        return GetByUriAsync<CallTrace>($"{UriPrefix}/{providerId}/RecentCalls/{callId}/pcap", cancellationToken);
    }

    /// <inheritdoc />
    public Task<LimitResult> CreateLimitAsync(string providerId, LimitCategory? category = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);

        return PostByUriAsync<CreateLimit, LimitResult>($"{UriPrefix}/{providerId}/Limits", new() { Category = category, }, cancellationToken);
    }

    /// <inheritdoc />
    public Task<ServiceProviderLeastCostRouting[]> ListLeastCostRoutingAsync(string providerId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);

        return GetByUriAsync<ServiceProviderLeastCostRouting[]>($"{UriPrefix}/{providerId}/lcrs", cancellationToken);
    }

    /// <inheritdoc />
    public Task<LeastCostRoutingResult> CreateLeastCostRoutingAsync(string providerId, CreateLeastCostRouting data, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(providerId);

        return PostByUriAsync<CreateLeastCostRouting, LeastCostRoutingResult>($"{UriPrefix}/{providerId}/lcrs", data, cancellationToken);
    }
}
