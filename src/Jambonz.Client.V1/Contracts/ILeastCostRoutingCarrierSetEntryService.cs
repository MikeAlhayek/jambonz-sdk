using Jambonz.Client.V1.Models.CallRouting;

namespace Jambonz.Client.V1.Contracts;

public interface ILeastCostRoutingCarrierSetEntryService
{
    /// <summary>
    /// Create a Least Cost Routing Carrier Set Entry.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<LeastCostRoutingCarrierSetEntryResult> CreateAsync(CreateLeastCostRoutingCarrierSetEntry data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a Least Cost Routing Carrier Set Entry.
    /// </summary>
    /// <param name="entryId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(string entryId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve least cost routing carrier set entry.
    /// </summary>
    /// <param name="entryId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<LeastCostRoutingCarrierSetEntry> GetAsync(string entryId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List least cost routings routes.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<LeastCostRoutingCarrierSetEntry[]> ListAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Least Cost Routing Carrier Set Entry.
    /// </summary>
    /// <param name="entryId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> UpdateAsync(string entryId, UpdateLeastCostRoutingCarrierSetEntry data, CancellationToken cancellationToken = default);
}
