using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.MicrosoftTeamsTenants;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class MicrosoftTeamsTenantsService : ApiBaseService, IMicrosoftTeamsTenantsService
{
    public MicrosoftTeamsTenantsService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/MicrosoftTeamsTenants", httpClientFactory, options)
    {
    }

    /// <inheritdoc/>
    public Task<MicrosoftTeamTenant> GetTenantAsync(string tenantId, CancellationToken cancellationToken = default)
        => GetRecordAsync<MicrosoftTeamTenant>(tenantId, cancellationToken);

    /// <inheritdoc/>
    public Task<MicrosoftTeamTenant[]> ListTenantsAsync(CancellationToken cancellationToken = default)
        => GetRecordsAsync<MicrosoftTeamTenant[]>(cancellationToken);

    /// <inheritdoc/>
    public Task<CreatedMicrosoftTeamTenant> CreateAsync(CreateMicrosoftTeamTenant data, CancellationToken cancellationToken = default)
        => CreateRecordAsync<CreateMicrosoftTeamTenant, CreatedMicrosoftTeamTenant>(data, cancellationToken);

    /// <inheritdoc/>
    public Task<bool> UpdateAsync(string tenantId, CreateMicrosoftTeamTenant data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(tenantId, data, cancellationToken);

    /// <inheritdoc/>
    public Task<bool> DeleteAsync(string tenantId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(tenantId, cancellationToken);
}
