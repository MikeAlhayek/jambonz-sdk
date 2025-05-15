using Jambonz.Client.V1.Models.Clients;

namespace Jambonz.Client.V1.Contracts;

public interface IClientsService
{
    Task<RegisteredClient[]> CreateClientRegistrationAsync(string accountId, IEnumerable<string> values, CancellationToken cancellationToken = default);

    Task<RegisteredClient> GetClientRegistrationAsync(string accountId, string clientId, CancellationToken cancellationToken = default);

    Task<string[]> GetRegisteredSipUsersAsync(string accountId, CancellationToken cancellationToken = default);
}
