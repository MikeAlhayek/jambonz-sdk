using Jambonz.Client.V1.Models;

namespace Jambonz.Client.V1.Contracts;

public interface IWebhooksService
{
    /// <summary>
    /// Retrieve a webhook.
    /// </summary>
    /// <param name="webhookId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Webhook> GetAsync(string webhookId, CancellationToken cancellationToken = default);
}
