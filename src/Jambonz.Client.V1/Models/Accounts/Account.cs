namespace Jambonz.Client.V1.Models.Accounts;

/// <summary>
/// Represents the configuration for a SIP device or tenant registration.
/// </summary>
public sealed class Account
{
    /// <summary>
    /// The unique identifier (UUID) of the account. Optional.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// The name of the configuration or tenant. Required.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The unique identifier (UUID) of the service provider. Required.
    /// </summary>
    public string ServiceProviderSid { get; set; }

    /// <summary>
    /// The SIP realm used for authentication. Required.
    /// </summary>
    public string SipRealm { get; set; }

    /// <summary>
    /// The webhook configuration for registration events. Optional.
    /// </summary>
    public RegistrationHook RegistrationHook { get; set; }

    /// <summary>
    /// The unique identifier (UUID) of the application used for device-initiated calls. Optional.
    /// </summary>
    public string DeviceCallingApplicationSid { get; set; }
}
