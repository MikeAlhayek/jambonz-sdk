using Jambonz.Client.V1.Models.CallRouting;
using Jambonz.Client.V1.Models.LeastCostRoutes;

namespace Jambonz.Client.V1.Contracts;

public interface ILeastCostRoutesService
{
    /// <summary>
    /// Create a Least Cost Routing Routes.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<LeastCostRouteResult> CreateAsync(CreateLeastCostRoutingRoute data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete least cost routings routes.
    /// </summary>
    /// <param name="routeId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(string routeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve least cost routings routes.
    /// </summary>
    /// <param name="routeId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<LeastCostRoute> GetAsync(string routeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List least cost routings routes.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<LeastCostRoute[]> ListAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update least cost routings routes.
    /// </summary>
    /// <param name="lcrId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> UpdateAsync(string lcrId, UpdateLeastCostRoute data, CancellationToken cancellationToken = default);
}
