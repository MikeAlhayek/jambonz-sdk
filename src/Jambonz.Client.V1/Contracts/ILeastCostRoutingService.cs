using Jambonz.Client.V1.Models.LeastCostRoutings;

namespace Jambonz.Client.V1.Contracts;

public interface ILeastCostRoutingService
{
    /// <summary>
    /// Create least cost routing.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<LeastCostRoutingResult> CreateAsync(CreateLeastCostRouting data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete least cost routing.
    /// </summary>
    /// <param name="lcrId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(string lcrId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve the least cost routing.
    /// </summary>
    /// <param name="lcrId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<LeastCostRouting> GetAsync(string lcrId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List least cost routings.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<LeastCostRouting[]> ListAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update least cost routing.
    /// </summary>
    /// <param name="lcrId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> UpdateAsync(string lcrId, UpdateLeastCostRouting data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create least cost routing routes and carrier set entries.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> CreateRoutingRouteAsync(string lcdId, CreateLeastCostRoutingRoute data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update least cost routing routes and carrier set entries.
    /// </summary>
    /// <param name="lcdId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> UpdateRoutingRouteAsync(string lcdId, UpdateLeastCostRoutingRoute data, CancellationToken cancellationToken = default);
}
