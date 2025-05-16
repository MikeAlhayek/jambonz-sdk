using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.VoipCarriers;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class VoipCarriersService : ApiBaseService, IVoipCarriersService
{
    public VoipCarriersService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/VoipCarriers", httpClientFactory, options)
    {
    }

    /// <inheritdoc/>
    public Task<VoipCarrier> GetAsync(string carrierId, CancellationToken cancellationToken = default)
       => GetRecordAsync<VoipCarrier>(carrierId, cancellationToken);

    /// <inheritdoc/>
    public Task<VoipCarrier[]> ListAsync(CancellationToken cancellationToken = default)
        => GetRecordsAsync<VoipCarrier[]>(cancellationToken);

    /// <inheritdoc/>
    public Task<CreatedVoipCarrier> CreateAsync(CreateVoipCarrier data, CancellationToken cancellationToken = default)
        => CreateRecordAsync<CreateVoipCarrier, CreatedVoipCarrier>(data, cancellationToken);

    /// <inheritdoc/>
    public Task UpdateAsync(string carrierId, UpdateVoipCarrier data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(carrierId, data, cancellationToken);

    /// <inheritdoc/>
    public Task<bool> DeleteAsync(string carrierId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(carrierId, cancellationToken);
}
