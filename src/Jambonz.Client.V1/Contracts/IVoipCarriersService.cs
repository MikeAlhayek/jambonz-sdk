using Jambonz.Client.V1.Models.VoipCarriers;

namespace Jambonz.Client.V1.Contracts;

public interface IVoipCarriersService
{
    /// <summary>
    /// Create a voip carrier.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<CreatedVoipCarrier> CreateAsync(CreateVoipCarrier data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a voip carrier.
    /// </summary>
    /// <param name="carrierId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a voip carrier.
    /// </summary>
    /// <param name="carrierId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<VoipCarrier> GetAsync(string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List voip carriers.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<VoipCarrier[]> ListAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a voip carrier.
    /// </summary>
    /// <param name="carrierId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateAsync(string carrierId, UpdateVoipCarrier data, CancellationToken cancellationToken = default);
}
