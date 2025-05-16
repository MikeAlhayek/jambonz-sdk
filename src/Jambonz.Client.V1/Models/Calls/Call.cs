namespace Jambonz.Client.V1.Models.Calls;
/// <summary>
/// Represents a telephony call with metadata and call state information.
/// </summary>
public sealed class Call
{
    /// <summary>
    /// The account SID associated with this call.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// The unique identifier of the call (internal use).
    /// </summary>
    public string CallId { get; set; }

    /// <summary>
    /// The unique SID of the call.
    /// </summary>
    public string CallSid { get; set; }

    /// <summary>
    /// The current status of the call (e.g., "trying", "in-progress", "completed").
    /// </summary>
    public CallStatus CallStatus { get; set; }

    /// <summary>
    /// The direction of the call, such as "inbound" or "outbound".
    /// </summary>
    public CallDirection? Direction { get; set; }

    /// <summary>
    /// The originator address of the call (usually a phone number or SIP URI).
    /// </summary>
    public string From { get; set; }

    /// <summary>
    /// The URL of the external service handling the call.
    /// </summary>
    public string ServiceUrl { get; set; }

    /// <summary>
    /// The numeric SIP status code associated with the call.
    /// </summary>
    public int SipStatus { get; set; }

    /// <summary>
    /// The destination address of the call (usually a phone number or SIP URI).
    /// </summary>
    public string To { get; set; }

    /// <summary>
    /// The SID of the application handling the call logic.
    /// </summary>
    public string ApplicationSid { get; set; }

    /// <summary>
    /// The name of the caller, if available.
    /// </summary>
    public string CallerName { get; set; }

    /// <summary>
    /// The duration of the call in seconds.
    /// </summary>
    public int Duration { get; set; }

    /// <summary>
    /// The name of the SIP trunk from which the call originated.
    /// </summary>
    public string OriginatingSipTrunkName { get; set; }

    /// <summary>
    /// The SID of the parent call if this is a child call (e.g., for call transfers).
    /// </summary>
    public string ParentCallSid { get; set; }
}

