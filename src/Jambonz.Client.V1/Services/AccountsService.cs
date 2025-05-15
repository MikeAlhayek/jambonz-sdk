using System.Net.Http.Json;
using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.Accounts;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class AccountsService : ApiBaseService, IAccountsService
{
    private static readonly StringContent _emptyContent = new(string.Empty);

    public AccountsService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/Accounts", httpClientFactory, options)
    {
    }

    public async Task<AccountAvailabilitiesResult> GetAvailabilityAsync(string type, string value, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(type);
        ArgumentException.ThrowIfNullOrEmpty(value);

        var client = GetClient();

        var response = await client.GetAsync($"v1/Availability?type={type}&value={value}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AccountAvailabilitiesResult>(Options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AccountWebhookSigningResult> GetWebhookSigningAsync(string accountId, bool? regenerate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        var client = GetClient();
        var uri = $"{UriPrefix}/{accountId}";

        if (regenerate.HasValue)
        {
            uri += $"?regenerate={regenerate.Value.ToString().ToLowerInvariant()}";
        }

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AccountWebhookSigningResult>(Options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> CreateOrUpdateSimpRealmAsync(string accountId, string sipRealmId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(sipRealmId);

        var client = GetClient();

        var response = await client.PostAsync($"{UriPrefix}/{accountId}/SipRealms/{sipRealmId}", _emptyContent, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<AccountResult> CreateLimitAsync(string accountId, LimitCategory? category = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        var client = GetClient();

        var response = await client.PostAsJsonAsync($"{UriPrefix}/{accountId}/Limits", new CreateLimit() { Category = category, }, Options.JsonSerializerOptions, cancellationToken);

        return await response.Content.ReadFromJsonAsync<AccountResult>(Options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AccountLimitResult[]> GetLimitsAsync(string accountId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        var client = GetClient();

        var response = await client.GetAsync($"{UriPrefix}/{accountId}/Limits", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AccountLimitResult[]>(Options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AccountApiKey[]> GetApiKeys(CancellationToken cancellationToken = default)
    {
        var client = GetClient();

        var response = await client.GetAsync("v1/ApiKeys", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AccountApiKey[]>(Options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CreatedApiKey> CreateApiKeys(string accountId, CancellationToken cancellationToken = default)
    {
        var client = GetClient();

        var response = await client.PostAsJsonAsync("v1/ApiKeys", new CreateApiKey() { AccountSid = accountId, }, Options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CreatedApiKey>(Options.JsonSerializerOptions, cancellationToken);
    }

    public Task<Account[]> GetAsync(CancellationToken cancellationToken = default)
        => GetRecordsAsync<Account[]>(cancellationToken);

    public Task<Account> GetAsync(string accountId, CancellationToken cancellationToken = default)
        => GetRecordAsync<Account>(accountId, cancellationToken);

    public Task<Account> CreateAsync(CreateAccount data, CancellationToken cancellationToken = default)
        => CreateRecordAsync<CreateAccount, Account>(data, cancellationToken);

    public Task UpdateAsync(string userId, UpdateAccount data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(userId, data, cancellationToken);

    public Task<bool> DeleteAsync(string accountId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(accountId, cancellationToken);
}
