using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class SbcsService : ApiBaseService, ISbcsService
{
    public SbcsService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/Sbcs", httpClientFactory, options)
    {
    }

    /// <inheritdoc/>
    public Task<IpAddressInfo[]> ListPublicIpAddresses(string providerId, CancellationToken cancellationToken = default)
    {
        var uri = UriPrefix;

        if (!string.IsNullOrEmpty(providerId))
        {
            uri += $"?service_provider_sid={providerId}";
        }

        return GetByUriAsync<IpAddressInfo[]>(uri, cancellationToken);
    }
}
