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

    public Task<MicrosoftTeamTenant> GetTenantAsync(string tenantId, CancellationToken cancellationToken = default)
        => GetRecordAsync<MicrosoftTeamTenant>(tenantId, cancellationToken);

    public Task<MicrosoftTeamTenant[]> GetTenantsAsync(CancellationToken cancellationToken = default)
        => GetRecordsAsync<MicrosoftTeamTenant[]>(cancellationToken);

    public Task<CreatedMicrosoftTeamTenant> CreateAsync(CreateMicrosoftTeamTenant data, CancellationToken cancellationToken = default)
        => CreateRecordAsync<CreateMicrosoftTeamTenant, CreatedMicrosoftTeamTenant>(data, cancellationToken);

    public Task<bool> UpdateAsync(string tenantId, CreateMicrosoftTeamTenant data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(tenantId, data, cancellationToken);

    public Task<bool> DeleteAsync(string tenantId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(tenantId, cancellationToken);
}
