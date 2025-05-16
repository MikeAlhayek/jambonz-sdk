using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.CallRouting;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class LeastCostRoutingService : ApiBaseService, ILeastCostRoutingService
{
    public LeastCostRoutingService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/Lcrs", httpClientFactory, options)
    {
    }

    /// <inheritdoc/>
    public Task<LeastCostRouting> GetAsync(string lcrId, CancellationToken cancellationToken = default)
        => GetRecordAsync<LeastCostRouting>(lcrId, cancellationToken);

    /// <inheritdoc/>
    public Task<LeastCostRouting[]> ListAsync(CancellationToken cancellationToken = default)
        => GetRecordsAsync<LeastCostRouting[]>(cancellationToken);

    /// <inheritdoc/>
    public Task<bool> DeleteAsync(string lcrId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(lcrId, cancellationToken);

    /// <inheritdoc/>
    public Task<LeastCostRoutingResult> CreateAsync(CreateLeastCostRouting data, CancellationToken cancellationToken = default)
        => CreateRecordAsync<CreateLeastCostRouting, LeastCostRoutingResult>(data, cancellationToken);

    /// <inheritdoc/>
    public Task<bool> UpdateAsync(string lcrId, UpdateLeastCostRouting data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(lcrId, data, cancellationToken);

    /// <inheritdoc/>
    public Task<bool> CreateRoutingRouteAsync(string lcdId, CreateLeastCostRoutingRoute data, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(lcdId);

        return PostByUriAsync($"{UriPrefix}/{lcdId}/Routes", data, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<bool> UpdateRoutingRouteAsync(string lcdId, UpdateLeastCostRoutingRoute data, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(lcdId);

        return PutByUriAsync($"{UriPrefix}/{lcdId}/Routes", data, cancellationToken);
    }
}
