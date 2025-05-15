namespace Jambonz.Client.V1.Models.Accounts;

/// <summary>
/// Represents the webhook configuration for SIP registration events.
/// </summary>
public sealed class RegistrationHook
{
    /// <summary>
    /// The URL to be called for the webhook. Required.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// The unique identifier (UUID) of the webhook configuration. Optional.
    /// </summary>
    public string WebhookSid { get; set; }

    /// <summary>
    /// The HTTP method to use for the webhook (e.g., GET, POST). Required.
    /// </summary>
    public string Method { get; set; }

    /// <summary>
    /// The username for basic authentication (if required). Optional.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// The password for basic authentication (if required). Optional.
    /// </summary>
    public string Password { get; set; }
}
