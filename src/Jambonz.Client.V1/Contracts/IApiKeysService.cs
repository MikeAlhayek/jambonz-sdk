using Jambonz.Client.V1.Models.Accounts;

namespace Jambonz.Client.V1.Contracts;

public interface IApiKeysService
{
    Task<CreatedApiKey> CreateApiKeys(string accountId, CancellationToken cancellationToken = default);

    Task<AccountApiKey[]> GetApiKeys(CancellationToken cancellationToken = default);
}
