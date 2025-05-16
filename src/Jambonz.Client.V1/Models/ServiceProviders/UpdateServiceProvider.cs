namespace Jambonz.Client.V1.Models.ServiceProviders;

/// <summary>
/// Represents the payload to update a service provider.
/// </summary>
public sealed class UpdateServiceProvider
{
    /// <summary>
    /// Unique identifier for the service provider (UUID format).
    /// </summary>
    public string ServiceProviderSid { get; set; }

    /// <summary>
    /// Name of the service provider.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Optional description of the service provider.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Optional root domain for the service provider.
    /// </summary>
    public string RootDomain { get; set; }

    /// <summary>
    /// Optional registration webhook configuration used for authentication.
    /// </summary>
    public Webhook RegistrationHook { get; set; }

    /// <summary>
    /// Optional Microsoft Teams Fully Qualified Domain Name.
    /// </summary>
    public string MsTeamsFqdn { get; set; }

    /// <summary>
    /// Optional test number used for inbound testing for accounts on the free plan.
    /// </summary>
    public string TestNumber { get; set; }

    /// <summary>
    /// Optional name of the test application available for new signups.
    /// </summary>
    public string TestApplicationName { get; set; }

    /// <summary>
    /// Optional identifier (SID) of the test application.
    /// </summary>
    public string TestApplicationSid { get; set; }
}
