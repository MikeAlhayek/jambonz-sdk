namespace Jambonz.Client.V1.Models.Calls;

/// <summary>
/// Represents an action for a conference participant.
/// </summary>
public sealed class ConferenceParticipantAction
{
    /// <summary>
    /// Action to apply to the participant (e.g., "kick", "mute").
    /// </summary>
    public ConferenceParticipantActionStatus Action { get; set; }

    /// <summary>
    /// Optional tag for contextual tracking.
    /// </summary>
    public string Tag { get; set; }
}
