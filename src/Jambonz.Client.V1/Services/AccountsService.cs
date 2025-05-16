using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.Accounts;
using Jambonz.Client.V1.Models.Alerts;
using Jambonz.Client.V1.Models.Calls;
using Jambonz.Client.V1.Models.Clients;
using Jambonz.Client.V1.Models.Queues;
using Jambonz.Client.V1.Models.Speech;
using Microsoft.AspNetCore.WebUtilities;
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

    /// <inheritdoc/>
    public Task<AccountWebhookSigningResult> GetWebhookSigningAsync(string accountId, bool? regenerate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        var uri = $"{UriPrefix}/{accountId}";

        if (regenerate.HasValue)
        {
            uri += $"?regenerate={regenerate.Value.ToString().ToLowerInvariant()}";
        }

        return GetByUriAsync<AccountWebhookSigningResult>(uri, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<bool> CreateOrUpdateSimpRealmAsync(string accountId, string sipRealmId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(sipRealmId);

        return PostByUriAsync($"{UriPrefix}/{accountId}/SipRealms/{sipRealmId}", _emptyContent, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<LimitResult> CreateLimitAsync(string accountId, LimitCategory? category = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return PostByUriAsync<CreateLimit, LimitResult>($"{UriPrefix}/{accountId}/Limits", new() { Category = category, }, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<AccountLimitResult[]> ListLimitsAsync(string accountId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return GetByUriAsync<AccountLimitResult[]>($"{UriPrefix}/{accountId}/Limits", cancellationToken);
    }

    /// <inheritdoc/>
    public Task<Account[]> ListAsync(CancellationToken cancellationToken = default)
        => GetRecordsAsync<Account[]>(cancellationToken);

    /// <inheritdoc/>
    public Task<Account> GetAsync(string accountId, CancellationToken cancellationToken = default)
        => GetRecordAsync<Account>(accountId, cancellationToken);

    /// <inheritdoc/>
    public Task<Account> CreateAsync(CreateAccount data, CancellationToken cancellationToken = default)
        => CreateRecordAsync<CreateAccount, Account>(data, cancellationToken);

    /// <inheritdoc/>
    public Task UpdateAsync(string userId, UpdateAccount data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(userId, data, cancellationToken);

    /// <inheritdoc/>
    public Task<bool> DeleteAsync(string accountId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(accountId, cancellationToken);

    /// <inheritdoc/>
    public Task<PagedResult<CallLogEntry>> PageRecentCallsAsync(string accountId, CallLogQueryContext context, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentNullException.ThrowIfNull(context);

        var queryParameters = new Dictionary<string, string>
        {
            { "page", ParameterToString(context.Page) },
            { "count", ParameterToString(context.Count) },
            { "days", ParameterToString(context.Days) },
        };

        if (context.Start.HasValue)
        {
            queryParameters.Add("start", ParameterToString(context.Start.Value));
        }

        if (context.End.HasValue)
        {
            queryParameters.Add("end", ParameterToString(context.End.Value));
        }

        if (context.Answered.HasValue)
        {
            queryParameters.Add("end", ParameterToString(context.End.Value));
        }

        if (context.Direction.HasValue)
        {
            queryParameters.Add("direction", ParameterToString(context.Direction.Value));
        }

        if (!string.IsNullOrEmpty(context.Filter))
        {
            queryParameters.Add("filter", ParameterToString(context.Filter));
        }

        var uri = QueryHelpers.AddQueryString($"{UriPrefix}/{accountId}/RecentCalls", queryParameters);

        return GetByUriAsync<PagedResult<CallLogEntry>>(uri, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<CallTrace> GetCallTraceAsync(string accountId, string callId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(callId);

        return GetByUriAsync<CallTrace>($"{UriPrefix}/{accountId}/RecentCalls/trace/{callId}", cancellationToken);
    }

    /// <inheritdoc/>
    public Task<CallTrace> GetCallPcapAsync(string accountId, string callId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(callId);

        return GetByUriAsync<CallTrace>($"{UriPrefix}/{accountId}/RecentCalls/{callId}/pcap", cancellationToken);
    }

    /// <inheritdoc/>
    public Task<PagedResult<AlertQueryContext>> PageAlertsAsync(string accountId, AlertQueryContext context, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentNullException.ThrowIfNull(context);

        var queryParameters = new Dictionary<string, string>
        {
            { "page", ParameterToString(context.Page) },
            { "count", ParameterToString(context.Count) },
            { "days", ParameterToString(context.Days) },
        };

        if (context.Start.HasValue)
        {
            queryParameters.Add("start", ParameterToString(context.Start.Value));
        }

        if (context.End.HasValue)
        {
            queryParameters.Add("end", ParameterToString(context.End.Value));
        }

        if (context.AlertType.HasValue)
        {
            queryParameters.Add("alert_type", ParameterToString(context.AlertType.Value));
        }

        var uri = QueryHelpers.AddQueryString($"{UriPrefix}/{accountId}/Alerts", queryParameters);

        return GetByUriAsync<PagedResult<AlertQueryContext>>(uri, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<Synthesize> GetTtsAsync(string accountId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return GetByUriAsync<Synthesize>($"{UriPrefix}/{accountId}/TtsCache/Synthesize", cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<KeyValuePair<string, SpeechCredentialTestResult>>> TestSpeechCredentialAsync(string accountId, string credentialId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(credentialId);

        return await GetByUriAsync<Dictionary<string, SpeechCredentialTestResult>>($"{UriPrefix}/{accountId}/SpeechCredentials/{credentialId}/test", cancellationToken);
    }

    /// <inheritdoc/>
    public Task<SpeechCredential> GetSpeechCredentialAsync(string accountId, string credentialId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(credentialId);

        return GetByUriAsync<SpeechCredential>($"{UriPrefix}/{accountId}/SpeechCredentials/{credentialId}", cancellationToken);
    }

    /// <inheritdoc/>
    public Task<bool> UpdateSpeechCredentialAsync(string accountId, string credentialId, UpdateSpeechCredential data, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(credentialId);

        return PutByUriAsync($"{UriPrefix}/{accountId}/SpeechCredentials/{credentialId}", data, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<bool> DeleteSpeechCredentialAsync(string accountId, string credentialId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(credentialId);

        return DeleteByUriAsync($"{UriPrefix}/{accountId}/SpeechCredentials/{credentialId}", cancellationToken);
    }

    /// <inheritdoc/>
    public Task<SpeechCredential[]> ListSpeechCredentialsAsync(string accountId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return GetByUriAsync<SpeechCredential[]>($"{UriPrefix}/{accountId}/SpeechCredentials", cancellationToken);
    }

    /// <inheritdoc/>
    public Task<SpeechCredentialResult> CreateSpeechCredentialsAsync(string accountId, CreateSpeechCredential data, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return PostByUriAsync<CreateSpeechCredential, SpeechCredentialResult>($"{UriPrefix}/{accountId}/SpeechCredentials", data, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<KeyValuePair<string, SupportedSpeech>>> GetSpeechLanguagesAndVoicesAsync(string accountId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return await GetByUriAsync<Dictionary<string, SupportedSpeech>>($"{UriPrefix}/{accountId}/SpeechCredentials/speech/supportedLanguagesAndVoices", cancellationToken);
    }

    public Task<string[]> ListRegisteredSipUsersAsync(string accountId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return GetByUriAsync<string[]>($"{UriPrefix}/{accountId}/RegisteredSipUsers", cancellationToken);
    }

    /// <inheritdoc/>
    public Task<RegisteredClient> GetClientRegistrationAsync(string accountId, string clientId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(clientId);

        return GetByUriAsync<RegisteredClient>($"{UriPrefix}/{accountId}/RegisteredSipUsers/{clientId}", cancellationToken);
    }

    /// <inheritdoc/>
    public Task<RegisteredClient[]> CreateClientRegistrationAsync(string accountId, IEnumerable<string> values, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return PostByUriAsync<IEnumerable<string>, RegisteredClient[]>($"{UriPrefix}/{accountId}/RegisteredSipUsers", values, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<Call> GetCallAsync(string accountId, string callId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(callId);

        return GetByUriAsync<Call>($"{UriPrefix}/{accountId}/Calls/{callId}", cancellationToken);
    }

    /// <inheritdoc/>
    public Task<bool> UpdateCallAsync(string accountId, string callId, UpdateCall data, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(callId);

        // For some reason the docs show this as a POST request not a PUT. Perhaps an documentation issue.
        return PostByUriAsync($"{UriPrefix}/{accountId}/Calls/{callId}", data, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<bool> DeleteCallsAsync(string accountId, string callId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(callId);

        return DeleteByUriAsync($"{UriPrefix}/{accountId}/Calls/{callId}", cancellationToken);
    }

    /// <inheritdoc/>
    public Task<Call[]> ListCallsAsync(string accountId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return GetByUriAsync<Call[]>($"{UriPrefix}/{accountId}/Calls", cancellationToken);
    }

    /// <inheritdoc/>
    public Task<string[]> ListConferencesAsync(string accountId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return GetByUriAsync<string[]>($"{UriPrefix}/{accountId}/Conferences", cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ActiveQueue[]> ListQueuesAsync(string accountId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return GetByUriAsync<ActiveQueue[]>($"{UriPrefix}/{accountId}/Queues", cancellationToken);
    }
}
