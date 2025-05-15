namespace Jambonz.Client.V1.Models;

/// <summary>
/// Represents a webhook configuration.
/// </summary>
public sealed class Webhook
{
    /// <summary>
    /// The URL to be called for the webhook. This field is required.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// The unique identifier (UUID) of the webhook. This field is optional.
    /// </summary>
    public string WebhookSid { get; set; }

    /// <summary>
    /// The HTTP method to use for the webhook (e.g., GET, POST). This field is optional.
    /// </summary>
    public AllowedHttpMethod? Method { get; set; }

    /// <summary>
    /// The username for basic authentication. This field is optional.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// The password for basic authentication. This field is optional.
    /// </summary>
    public string Password { get; set; }
}
