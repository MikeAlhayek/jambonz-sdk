using Jambonz.Client.V1.Models.Accounts;
using Jambonz.Client.V1.Models.Alerts;
using Jambonz.Client.V1.Models.Calls;
using Jambonz.Client.V1.Models.Clients;
using Jambonz.Client.V1.Models.Queues;
using Jambonz.Client.V1.Models.Speech;

namespace Jambonz.Client.V1.Contracts;

public interface IAccountsService
{
    /// <summary>
    /// Delete an account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(string accountId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an account.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Account> CreateAsync(CreateAccount data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update an account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateAsync(string accountId, UpdateAccount data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Account> GetAsync(string accountId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List accounts.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Account[]> ListAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve call capacity and other limits from the account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<AccountLimitResult[]> ListLimitsAsync(string accountId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a limit for an account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="category"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<LimitResult> CreateLimitAsync(string accountId, LimitCategory? category = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add or change the sip realm.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="sipRealmId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> CreateOrUpdateSimpRealmAsync(string accountId, string sipRealmId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get webhook signing secret, regenerating if requested.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="regenerate"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<AccountWebhookSigningResult> GetWebhookSigningAsync(string accountId, bool? regenerate = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve recent calls for an account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="context"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<PagedResult<CallLogEntry>> PageRecentCallsAsync(string accountId, CallLogQueryContext context, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve jaeger trace detail for a call.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="callId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<CallTrace> GetCallTraceAsync(string accountId, string callId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve pcap for a call.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="callId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<CallTrace> GetCallPcapAsync(string accountId, string callId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve alerts for an account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="context"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<PagedResult<AlertQueryContext>> PageAlertsAsync(string accountId, AlertQueryContext context, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a speech credentials for an account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="credentialId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<SpeechCredential> GetSpeechCredentialAsync(string accountId, string credentialId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a speech credential.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="credentialId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> UpdateSpeechCredentialAsync(string accountId, string credentialId, UpdateSpeechCredential data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a speech credential.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="credentialId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DeleteSpeechCredentialAsync(string accountId, string credentialId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all speech credentials for an account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<SpeechCredential[]> ListSpeechCredentialsAsync(string accountId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a speech credential.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<SpeechCredentialResult> CreateSpeechCredentialsAsync(string accountId, CreateSpeechCredential data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve online sip users for an account by list of sip username.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="values"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<RegisteredClient[]> CreateClientRegistrationAsync(string accountId, IEnumerable<string> values, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve registered client registration.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="clientId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<RegisteredClient> GetClientRegistrationAsync(string accountId, string clientId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve online sip users for an account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<string[]> ListRegisteredSipUsersAsync(string accountId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a call.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="callId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Call> GetCallAsync(string accountId, string callId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a call.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="callId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> UpdateCallAsync(string accountId, string callId, UpdateCall data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a call.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="callId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DeleteCallsAsync(string accountId, string callId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List calls.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Call[]> ListCallsAsync(string accountId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve conferences for an account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<string[]> ListConferencesAsync(string accountId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve active queues for an account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ActiveQueue[]> ListQueuesAsync(string accountId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Test a speech credential.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="credentialId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IEnumerable<KeyValuePair<string, SpeechCredentialTestResult>>> TestSpeechCredentialAsync(string accountId, string credentialId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get TTS from provider.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Synthesize> GetTtsAsync(string accountId, CancellationToken cancellationToken = default);
}
