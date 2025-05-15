using Jambonz.Client.V1.Models.Accounts;

namespace Jambonz.Client.V1.Contracts;

public interface IAccountsService
{
    Task<bool> DeleteAsync(string accountId, CancellationToken cancellationToken = default);

    Task<CreatedApiKey> CreateApiKeys(string accountId, CancellationToken cancellationToken = default);

    Task<Account> CreateAsync(CreateAccount data, CancellationToken cancellationToken = default);

    Task<AccountResult> CreateLimitAsync(string accountId, LimitCategory? category = null, CancellationToken cancellationToken = default);

    Task<bool> CreateOrUpdateSimpRealmAsync(string accountId, string sipRealmId, CancellationToken cancellationToken = default);

    Task<AccountApiKey[]> GetApiKeys(CancellationToken cancellationToken = default);

    Task<Account> GetAsync(string accountId, CancellationToken cancellationToken = default);

    Task<Account[]> GetAsync(CancellationToken cancellationToken = default);

    Task<AccountAvailabilitiesResult> GetAvailabilityAsync(string type, string value, CancellationToken cancellationToken = default);

    Task<AccountLimitResult[]> GetLimitsAsync(string accountId, CancellationToken cancellationToken = default);

    Task<AccountWebhookSigningResult> GetWebhookSigningAsync(string accountId, bool? regenerate = null, CancellationToken cancellationToken = default);

    Task UpdateAsync(string userId, UpdateAccount data, CancellationToken cancellationToken = default);
}
