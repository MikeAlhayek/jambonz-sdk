using Jambonz.Client.V1.Models;

namespace Jambonz.Client.V1.Contracts;

public interface IWebhooksService
{
    Task<Webhook> GetAsync(string webhookId, CancellationToken cancellationToken = default);
}
