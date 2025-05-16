using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.CallRouting;
using Jambonz.Client.V1.Models.LeastCostRoutes;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class LeastCostRoutesService : ApiBaseService, ILeastCostRoutesService
{
    public LeastCostRoutesService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/LcrRoutes", httpClientFactory, options)
    {
    }

    /// <inheritdoc/>
    public Task<LeastCostRoute> GetAsync(string routeId, CancellationToken cancellationToken = default)
        => GetRecordAsync<LeastCostRoute>(routeId, cancellationToken);

    /// <inheritdoc/>
    public Task<LeastCostRoute[]> ListAsync(CancellationToken cancellationToken = default)
        => GetRecordsAsync<LeastCostRoute[]>(cancellationToken);

    /// <inheritdoc/>
    public Task<bool> DeleteAsync(string routeId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(routeId, cancellationToken);

    /// <inheritdoc/>
    public Task<LeastCostRouteResult> CreateAsync(CreateLeastCostRoutingRoute data, CancellationToken cancellationToken = default)
        => CreateRecordAsync<CreateLeastCostRoutingRoute, LeastCostRouteResult>(data, cancellationToken);

    /// <inheritdoc/>
    public Task<bool> UpdateAsync(string routeId, UpdateLeastCostRoute data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(routeId, data, cancellationToken);
}
