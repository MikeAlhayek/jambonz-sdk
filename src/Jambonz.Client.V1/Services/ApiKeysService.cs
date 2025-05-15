using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.Accounts;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class ApiKeysService : ApiBaseService, IApiKeysService
{
    public ApiKeysService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/ApiKeys", httpClientFactory, options)
    {
    }

    public Task<AccountApiKey[]> GetApiKeys(CancellationToken cancellationToken = default)
        => GetRecordsAsync<AccountApiKey[]>(cancellationToken);

    public Task<CreatedApiKey> CreateApiKeys(string accountId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(accountId);

        return CreateRecordAsync<CreateApiKey, CreatedApiKey>(new() { AccountSid = accountId, }, cancellationToken);
    }
}
