using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.Clients;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class ClientsService : ApiBaseService, IClientsService
{
    public ClientsService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/Accounts", httpClientFactory, options)
    {
    }

    public Task<string[]> GetRegisteredSipUsersAsync(string accountId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return GetByUriAsync<string[]>($"{UriPrefix}/{accountId}/RegisteredSipUsers", cancellationToken);
    }

    public Task<RegisteredClient> GetClientRegistrationAsync(string accountId, string clientId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        return GetByUriAsync<RegisteredClient>($"{UriPrefix}/{accountId}/RegisteredSipUsers/{clientId}", cancellationToken);
    }

    public Task<RegisteredClient[]> CreateClientRegistrationAsync(string accountId, IEnumerable<string> values, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return PostByUriAsync<IEnumerable<string>, RegisteredClient[]>($"{UriPrefix}/{accountId}/RegisteredSipUsers", values, cancellationToken);
    }
}
