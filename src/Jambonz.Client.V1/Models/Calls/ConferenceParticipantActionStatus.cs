using System.Runtime.Serialization;

namespace Jambonz.Client.V1.Models.Calls;

/// <summary>
/// Represents actions that can be performed on a conference participant.
/// </summary>
public enum ConferenceParticipantActionStatus
{
    /// <summary>
    /// Tag the participant.
    /// </summary>
    [EnumMember(Value = "tag")]
    Tag,

    /// <summary>
    /// Remove the tag from the participant.
    /// </summary>
    [EnumMember(Value = "untag")]
    Untag,

    /// <summary>
    /// Set the participant to coach mode.
    /// </summary>
    [EnumMember(Value = "coach")]
    Coach,

    /// <summary>
    /// Remove the participant from coach mode.
    /// </summary>
    [EnumMember(Value = "uncoach")]
    Uncoach,

    /// <summary>
    /// Mute the participant.
    /// </summary>
    [EnumMember(Value = "mute")]
    Mute,

    /// <summary>
    /// Unmute the participant.
    /// </summary>
    [EnumMember(Value = "unmute")]
    Unmute,

    /// <summary>
    /// Put the participant on hold.
    /// </summary>
    [EnumMember(Value = "hold")]
    Hold,

    /// <summary>
    /// Remove the participant from hold.
    /// </summary>
    [EnumMember(Value = "unhold")]
    Unhold
}
