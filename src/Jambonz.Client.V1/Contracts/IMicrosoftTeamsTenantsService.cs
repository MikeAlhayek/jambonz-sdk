using Jambonz.Client.V1.Models.MicrosoftTeamsTenants;

namespace Jambonz.Client.V1.Contracts;

public interface IMicrosoftTeamsTenantsService
{
    /// <summary>
    /// Provision a customer tenant for MS Teams.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<CreatedMicrosoftTeamTenant> CreateAsync(CreateMicrosoftTeamTenant data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an MS Teams tenant.
    /// </summary>
    /// <param name="tenantId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(string tenantId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve an MS Teams tenant.
    /// </summary>
    /// <param name="tenantId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<MicrosoftTeamTenant> GetTenantAsync(string tenantId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List MS Teams tenants.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<MicrosoftTeamTenant[]> ListTenantsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update an MS Teams tenant.
    /// </summary>
    /// <param name="tenantId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> UpdateAsync(string tenantId, CreateMicrosoftTeamTenant data, CancellationToken cancellationToken = default);
}
