namespace Jambonz.Client.V1.Models.Calls;

/// <summary>
/// Represents a single call log entry with metadata and call status.
/// </summary>
public sealed class CallLogEntry
{
    /// <summary>
    /// The unique identifier of the account.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// The unique identifier for the call.
    /// </summary>
    public string CallSid { get; set; }

    /// <summary>
    /// The caller's address or number.
    /// </summary>
    public string From { get; set; }

    /// <summary>
    /// The recipient's address or number.
    /// </summary>
    public string To { get; set; }

    /// <summary>
    /// Indicates whether the call was answered.
    /// </summary>
    public bool Answered { get; set; }

    /// <summary>
    /// SIP status code at call initiation or termination.
    /// </summary>
    public int SipStatus { get; set; }

    /// <summary>
    /// Duration of the call in seconds.
    /// </summary>
    public int Duration { get; set; }

    /// <summary>
    /// Timestamp of when the call was attempted (Unix epoch).
    /// </summary>
    public long AttemptedAt { get; set; }

    /// <summary>
    /// Timestamp of when the call was terminated (Unix epoch).
    /// </summary>
    public long TerminatedAt { get; set; }

    /// <summary>
    /// Call direction, such as "inbound" or "outbound".
    /// </summary>
    public string Direction { get; set; }

    /// <summary>
    /// The SIP Call-ID for tracing SIP signaling.
    /// </summary>
    public string SipCallId { get; set; }

    /// <summary>
    /// Timestamp of when the call was answered (Unix epoch).
    /// </summary>
    public long AnsweredAt { get; set; }

    /// <summary>
    /// Reason the call was terminated, if applicable.
    /// </summary>
    public string TerminationReason { get; set; }

    /// <summary>
    /// The host server that processed the call.
    /// </summary>
    public string Host { get; set; }

    /// <summary>
    /// The remote host (e.g., peer gateway or client IP).
    /// </summary>
    public string RemoteHost { get; set; }

    /// <summary>
    /// The trunk name or identifier used for the call.
    /// </summary>
    public string Trunk { get; set; }
}
