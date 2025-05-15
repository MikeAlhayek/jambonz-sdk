using Jambonz.Client.V1.Models;

namespace Jambonz.Client.V1.Contracts;

public interface ISbcsService
{
    Task<IpAddressInfo[]> GetPublicIpAddresses(string providerId, CancellationToken cancellationToken = default);
}
