using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.SipGateways;
using Jambonz.Client.V1.Models.VoipCarriers;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class SipGatewaysService : ApiBaseService, ISipGatewaysService
{
    public SipGatewaysService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/SipGateways", httpClientFactory, options)
    {
    }

    /// <inheritdoc/>
    public Task<SipGateway> GetAsync(string gatewayId, CancellationToken cancellationToken = default)
       => GetRecordAsync<SipGateway>(gatewayId, cancellationToken);

    /// <inheritdoc/>
    public Task<SipGateway[]> ListAsync(CancellationToken cancellationToken = default)
        => GetRecordsAsync<SipGateway[]>(cancellationToken);

    /// <inheritdoc/>
    public Task<CreatedSipGateway> CreateAsync(CreateSipGateway data, CancellationToken cancellationToken = default)
        => CreateRecordAsync<CreateSipGateway, CreatedSipGateway>(data, cancellationToken);

    /// <inheritdoc/>
    public Task UpdateAsync(string gatewayId, UpdateVoipCarrier data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(gatewayId, data, cancellationToken);

    /// <inheritdoc/>
    public Task<bool> DeleteAsync(string gatewayId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(gatewayId, cancellationToken);
}
