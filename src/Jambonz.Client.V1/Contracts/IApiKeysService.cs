using Jambonz.Client.V1.Models.Accounts;

namespace Jambonz.Client.V1.Contracts;

public interface IApiKeysService
{
    /// <summary>
    /// Create an API key for an account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<CreatedApiKey> CreateApiKeys(string accountId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List all api keys for an account.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<AccountApiKey[]> ListApiKeys(CancellationToken cancellationToken = default);
}
