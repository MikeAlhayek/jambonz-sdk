using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models;
using Jambonz.Client.V1.Models.Accounts;
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

    public Task<bool> CreateOrUpdateSimpRealmAsync(string accountId, string sipRealmId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(sipRealmId);

        return PostByUriAsync($"{UriPrefix}/{accountId}/SipRealms/{sipRealmId}", _emptyContent, cancellationToken);
    }

    public Task<AccountResult> CreateLimitAsync(string accountId, LimitCategory? category = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return PostByUriAsync<CreateLimit, AccountResult>($"{UriPrefix}/{accountId}/Limits", new() { Category = category, }, cancellationToken);
    }

    public Task<AccountLimitResult[]> GetLimitsAsync(string accountId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return GetByUriAsync<AccountLimitResult[]>($"{UriPrefix}/{accountId}/Limits", cancellationToken);
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

    public Task<PagedResult<CallLogEntry>> GetRecentCallsAsync(string accountId, CallLogQueryContext context, CancellationToken cancellationToken = default)
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

    public Task<CallTrace> GetCallTraceAsync(string accountId, string callId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(callId);

        return GetByUriAsync<CallTrace>($"{UriPrefix}/{accountId}/RecentCalls/trace/{callId}", cancellationToken);
    }

    public Task<CallTrace> GetCallPcapAsync(string accountId, string callId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);
        ArgumentException.ThrowIfNullOrEmpty(callId);

        return GetByUriAsync<CallTrace>($"{UriPrefix}/{accountId}/RecentCalls/{callId}/pcap", cancellationToken);
    }

    public Task<PagedResult<AlertQueryContext>> GetAlertsAsync(string accountId, AlertQueryContext context, CancellationToken cancellationToken = default)
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
}
