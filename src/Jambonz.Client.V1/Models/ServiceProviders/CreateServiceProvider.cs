namespace Jambonz.Client.V1.Models.ServiceProviders;

/// <summary>
/// Represents the payload to create a new service provider.
/// </summary>
public sealed class CreateServiceProvider
{
    /// <summary>
    /// Name of the service provider.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Optional description of the service provider.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Optional root domain for a group of accounts sharing a registration hook.
    /// </summary>
    public string RootDomain { get; set; }

    /// <summary>
    /// Optional registration webhook configuration used for authentication.
    /// </summary>
    public Webhook RegistrationHook { get; set; }

    /// <summary>
    /// Optional SBC domain name for Microsoft Teams integration.
    /// </summary>
    public string MsTeamsFqdn { get; set; }
}
