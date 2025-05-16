using Jambonz.Client.V1.Models.Accounts;

namespace Jambonz.Client.V1.Models.ServiceProviders;

/// <summary>
/// Represents a service provider entity.
/// </summary>
public sealed class ServiceProvider
{
    /// <summary>
    /// Unique identifier of the service provider (UUID format).
    /// </summary>
    public string ServiceProviderSid { get; set; }

    /// <summary>
    /// Name of the service provider.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Description of the service provider. Optional.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Root domain for the service provider. Optional.
    /// </summary>
    public string RootDomain { get; set; }

    /// <summary>
    /// Webhook for registration authentication. Optional.
    /// </summary>
    public Webhook RegistrationHook { get; set; }

    /// <summary>
    /// Microsoft Teams Fully Qualified Domain Name. Optional.
    /// </summary>
    public string MsTeamsFqdn { get; set; }

    /// <summary>
    /// Test number used for inbound testing on free accounts. Optional.
    /// </summary>
    public string TestNumber { get; set; }

    /// <summary>
    /// Name of the test application for new signups. Optional.
    /// </summary>
    public string TestApplicationName { get; set; }

    /// <summary>
    /// SID of the test application. Optional.
    /// </summary>
    public string TestApplicationSid { get; set; }
}
