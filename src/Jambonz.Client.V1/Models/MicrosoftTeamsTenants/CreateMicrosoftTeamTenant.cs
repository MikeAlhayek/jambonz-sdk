namespace Jambonz.Client.V1.Models.MicrosoftTeamsTenants;

/// <summary>
/// Represents the payload expected by the endpoint.
/// </summary>
public sealed class CreateMicrosoftTeamTenant
{
    /// <summary>
    /// The unique identifier (UUID) of the service provider. This field is required.
    /// </summary>
    public string ServiceProviderSid { get; set; }

    /// <summary>
    /// The fully qualified domain name of the tenant. This field is required.
    /// </summary>
    public string TenantFqdn { get; set; }

    /// <summary>
    /// The unique identifier (UUID) of the account. This field is optional.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// The unique identifier (UUID) of the application. This field is optional.
    /// </summary>
    public string ApplicationSid { get; set; }
}
