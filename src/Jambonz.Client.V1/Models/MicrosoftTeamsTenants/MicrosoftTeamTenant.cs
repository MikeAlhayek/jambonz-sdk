namespace Jambonz.Client.V1.Models.MicrosoftTeamsTenants;

/// <summary>
/// Represents a Microsoft Teams tenant configuration.
/// </summary>
public sealed class MicrosoftTeamTenant
{
    /// <summary>
    /// The unique identifier of the service provider associated with this tenant.
    /// </summary>
    public string ServiceProviderSid { get; set; }

    /// <summary>
    /// The fully qualified domain name (FQDN) of the Microsoft Teams tenant.
    /// </summary>
    public string TenantFqdn { get; set; }

    /// <summary>
    /// The account SID linked to this tenant.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// The SID of the application associated with this tenant.
    /// </summary>
    public string ApplicationSid { get; set; }
}
