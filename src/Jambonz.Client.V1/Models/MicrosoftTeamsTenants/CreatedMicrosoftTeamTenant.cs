namespace Jambonz.Client.V1.Models.MicrosoftTeamsTenants;

/// <summary>
/// Represents a Microsoft Teams tenant configuration.
/// </summary>
public sealed class CreatedMicrosoftTeamTenant
{
    /// <summary>
    /// The SID of the application associated with this tenant.
    /// </summary>
    public string Sid { get; set; }
}
