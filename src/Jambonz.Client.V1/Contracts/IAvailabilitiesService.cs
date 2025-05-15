using Jambonz.Client.V1.Models.Accounts;

namespace Jambonz.Client.V1.Contracts;

public interface IAvailabilitiesService
{
    Task<AccountAvailabilitiesResult> GetAvailabilityAsync(string type, string value, CancellationToken cancellationToken = default);
}
