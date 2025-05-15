using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class WebhooksService : ApiBaseService, IWebhooksService
{
    public WebhooksService(
    IHttpClientFactory httpClientFactory,
    IOptions<JambonzJsonSerializerOptions> options)
    : base("v1/Webhooks", httpClientFactory, options)
    {
    }

    public Task<Webhook> GetAsync(string webhookId, CancellationToken cancellationToken = default)
        => GetRecordAsync<Webhook>(webhookId, cancellationToken);
}
