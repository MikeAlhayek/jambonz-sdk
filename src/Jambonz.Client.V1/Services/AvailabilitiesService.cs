using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.Accounts;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class AvailabilitiesService : ApiBaseService, IAvailabilitiesService
{
    public AvailabilitiesService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/Availability", httpClientFactory, options)
    {
    }

    /// <inheritdoc/>
    public Task<AccountAvailabilitiesResult> GetAvailabilityAsync(string type, string value, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(type);
        ArgumentException.ThrowIfNullOrEmpty(value);

        return GetByUriAsync<AccountAvailabilitiesResult>($"{UriPrefix}?type={type}&value={value}", cancellationToken);
    }
}
