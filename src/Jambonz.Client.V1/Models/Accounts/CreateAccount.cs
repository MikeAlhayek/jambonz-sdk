namespace Jambonz.Client.V1.Models.Accounts;

/// <summary>
/// Represents the request payload for configuring an account with optional webhook hooks.
/// </summary>
public sealed class CreateAccount
{
    /// <summary>
    /// The name of the account. This field is required.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The unique identifier (UUID) of the service provider. This field is required.
    /// </summary>
    public string ServiceProviderSid { get; set; }

    /// <summary>
    /// The SIP realm used for registration. This field is optional.
    /// </summary>
    public string SipRealm { get; set; }

    /// <summary>
    /// The webhook configuration for SIP registration authentication. This field is optional.
    /// </summary>
    public Webhook RegistrationHook { get; set; }

    /// <summary>
    /// The webhook configuration triggered when members join or leave a queue. This field is optional.
    /// </summary>
    public Webhook QueueEventHook { get; set; }
}
