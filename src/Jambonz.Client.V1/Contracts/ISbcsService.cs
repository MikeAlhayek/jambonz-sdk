using Jambonz.Client.V1.Models;

namespace Jambonz.Client.V1.Contracts;

public interface ISbcsService
{
    /// <summary>
    /// Retrieve public IP addresses of the jambonz SBCs.
    /// </summary>
    /// <param name="providerId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IpAddressInfo[]> ListPublicIpAddresses(string providerId, CancellationToken cancellationToken = default);
}
