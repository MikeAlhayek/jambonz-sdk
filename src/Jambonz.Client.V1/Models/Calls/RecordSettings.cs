namespace Jambonz.Client.V1.Models.Calls;

/// <summary>
/// Represents an action to be taken related to recording the call.
/// </summary>
public sealed class RecordSettings
{
    /// <summary>
    /// Optional recording action (e.g., "start", "stop").
    /// </summary>
    public string Action { get; set; }

    /// <summary>
    /// Optional recording ID for tracking.
    /// </summary>
    public string RecordingID { get; set; }

    /// <summary>
    /// Optional SIPREC server URL.
    /// </summary>
    public string SiprecServerURL { get; set; }
}
