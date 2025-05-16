using Jambonz.Client.V1.Models.SipGateways;
using Jambonz.Client.V1.Models.VoipCarriers;

namespace Jambonz.Client.V1.Contracts;

public interface ISipGatewaysService
{
    /// <summary>
    /// Create sip gateway.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<CreatedSipGateway> CreateAsync(CreateSipGateway data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete sip gateway.
    /// </summary>
    /// <param name="gatewayId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(string gatewayId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve sip gateway.
    /// </summary>
    /// <param name="gatewayId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<SipGateway> GetAsync(string gatewayId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List sip gateways.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<SipGateway[]> ListAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update sip gateway.
    /// </summary>
    /// <param name="gatewayId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateAsync(string gatewayId, UpdateVoipCarrier data, CancellationToken cancellationToken = default);
}
