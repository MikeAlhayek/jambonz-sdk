using Jambonz.Client.V1.Models.MicrosoftTeamsTenants;

namespace Jambonz.Client.V1.Contracts;

public interface IMicrosoftTeamsTenantsService
{
    Task<CreatedMicrosoftTeamTenant> CreateAsync(CreateMicrosoftTeamTenant data, CancellationToken cancellationToken = default);

    Task<MicrosoftTeamTenant> GetTenantAsync(string tenantId, CancellationToken cancellationToken = default);

    Task<MicrosoftTeamTenant[]> GetTenantsAsync(CancellationToken cancellationToken = default);

    Task<bool> UpdateAsync(string tenantId, CreateMicrosoftTeamTenant data, CancellationToken cancellationToken = default);
}
