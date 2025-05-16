using Jambonz.Client.V1.Models.Accounts;

namespace Jambonz.Client.V1.Contracts;

public interface IAvailabilitiesService
{
    /// <summary>
    /// Check if a limited-availability entity such as a subdomain, email or phone number is already in use.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<AccountAvailabilitiesResult> GetAvailabilityAsync(string type, string value, CancellationToken cancellationToken = default);
}
