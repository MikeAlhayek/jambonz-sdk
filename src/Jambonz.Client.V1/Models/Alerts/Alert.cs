namespace Jambonz.Client.V1.Models.Alerts;

/// <summary>
/// Represents a single alert entry with associated metadata.
/// </summary>
public sealed class Alert
{
    /// <summary>
    /// The timestamp of the alert (ISO 8601 format).
    /// </summary>
    public string Time { get; set; }

    /// <summary>
    /// The unique identifier of the account associated with the alert.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// The type or category of the alert.
    /// </summary>
    public AlertTypes? AlertType { get; set; }

    /// <summary>
    /// The main alert message.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Additional details about the alert.
    /// </summary>
    public string Detail { get; set; }
}
