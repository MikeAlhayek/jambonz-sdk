namespace Jambonz.Client.V1.Models.Users;

/// <summary>
/// Contains account information for the current user.
/// </summary>
public sealed class CurrentAccountInfo
{
    /// <summary>
    /// Unique identifier for the account.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// SIP realm used for authentication.
    /// </summary>
    public string SipRealm { get; set; }

    /// <summary>
    /// Identifier of the service provider.
    /// </summary>
    public string ServiceProviderSid { get; set; }

    /// <summary>
    /// Hook SID for SIP registration events.
    /// </summary>
    public string RegistrationHookSid { get; set; }

    /// <summary>
    /// Hook SID for queue events.
    /// </summary>
    public string QueueEventHookSid { get; set; }

    /// <summary>
    /// SID of the application used for device calls.
    /// </summary>
    public string DeviceCallingApplicationSid { get; set; }

    /// <summary>
    /// Indicates if the account is active.
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Timestamp of account creation.
    /// </summary>
    public DateTime CreatedAt { get; set; }
}
