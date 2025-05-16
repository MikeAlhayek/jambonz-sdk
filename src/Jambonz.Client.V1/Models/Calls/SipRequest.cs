namespace Jambonz.Client.V1.Models.Calls;

/// <summary>
/// Represents a SIP request to be triggered during call update.
/// </summary>
public sealed class SipRequest
{
    /// <summary>
    /// Optional HTTP method to use.
    /// </summary>
    public string Method { get; set; }

    /// <summary>
    /// Optional MIME type of the SIP message content.
    /// </summary>
    public string ContentType { get; set; }

    /// <summary>
    /// Optional body of the SIP message.
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// Optional headers for the SIP message.
    /// </summary>
    public Dictionary<string, object> Headers { get; set; }
}
