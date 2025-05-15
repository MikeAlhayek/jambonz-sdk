using System.Net.Http.Json;
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

    public async Task<string[]> GetRegisteredSipUsersAsync(string accountId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        var client = GetClient();

        var response = await client.GetAsync($"{UriPrefix}/{accountId}/RegisteredSipUsers", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<string[]>(Options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<RegisteredClient> GetClientRegistrationAsync(string accountId, string clientId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        var client = GetClient();

        var response = await client.GetAsync($"{UriPrefix}/{accountId}/RegisteredSipUsers/{clientId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RegisteredClient>(Options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<RegisteredClient[]> CreateClientRegistrationAsync(string accountId, IEnumerable<string> values, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        var client = GetClient();

        var response = await client.PostAsJsonAsync($"{UriPrefix}/{accountId}/RegisteredSipUsers", values, Options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RegisteredClient[]>(Options.JsonSerializerOptions, cancellationToken);
    }
}
