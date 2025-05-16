using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.CallRouting;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class LeastCostRoutingCarrierSetEntryService : ApiBaseService, ILeastCostRoutingCarrierSetEntryService
{
    public LeastCostRoutingCarrierSetEntryService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/LcrCarrierSetEntries", httpClientFactory, options)
    {
    }

    /// <inheritdoc/>
    public Task<LeastCostRoutingCarrierSetEntry> GetAsync(string entryId, CancellationToken cancellationToken = default)
        => GetRecordAsync<LeastCostRoutingCarrierSetEntry>(entryId, cancellationToken);

    /// <inheritdoc/>
    public Task<LeastCostRoutingCarrierSetEntry[]> ListAsync(CancellationToken cancellationToken = default)
        => GetRecordsAsync<LeastCostRoutingCarrierSetEntry[]>(cancellationToken);

    /// <inheritdoc/>
    public Task<bool> DeleteAsync(string entryId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(entryId, cancellationToken);

    /// <inheritdoc/>
    public Task<LeastCostRoutingCarrierSetEntryResult> CreateAsync(CreateLeastCostRoutingCarrierSetEntry data, CancellationToken cancellationToken = default)
        => CreateRecordAsync<CreateLeastCostRoutingCarrierSetEntry, LeastCostRoutingCarrierSetEntryResult>(data, cancellationToken);

    /// <inheritdoc/>
    public Task<bool> UpdateAsync(string entryId, UpdateLeastCostRoutingCarrierSetEntry data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(entryId, data, cancellationToken);
}
