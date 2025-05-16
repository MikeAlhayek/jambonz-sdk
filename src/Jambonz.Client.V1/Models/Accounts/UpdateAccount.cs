namespace Jambonz.Client.V1.Models.Accounts;

/// <summary>
/// Represents the request payload for the registration configuration endpoint.
/// </summary>
public sealed class UpdateAccount
{
    /// <summary>
    /// The unique identifier (UUID) of the account. This field is required.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// The name of the registration configuration. This field is required.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The unique identifier (UUID) of the service provider. This field is required.
    /// </summary>
    public string ServiceProviderSid { get; set; }

    /// <summary>
    /// The SIP realm used for authentication. This field is optional.
    /// </summary>
    public string SipRealm { get; set; }

    /// <summary>
    /// The webhook configuration used for SIP registration authentication. This field is optional.
    /// </summary>
    public Webhook RegistrationHook { get; set; }
}
