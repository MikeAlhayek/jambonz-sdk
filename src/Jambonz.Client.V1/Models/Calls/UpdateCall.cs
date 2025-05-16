namespace Jambonz.Client.V1.Models.Calls;

/// <summary>
/// Represents a request to update call-related parameters and behavior.
/// </summary>
public sealed class UpdateCall
{
    /// <summary>
    /// Optional webhook settings for the main call.
    /// </summary>
    public Webhook CallHook { get; set; }

    /// <summary>
    /// Optional webhook settings for the child call.
    /// </summary>
    public Webhook ChildCallHook { get; set; }

    /// <summary>
    /// Optional updated call status.
    /// Allowed values depend on system definitions.
    /// </summary>
    public CallStatus? CallStatus { get; set; }

    /// <summary>
    /// Optional conference mute status.
    /// Allowed values depend on system definitions.
    /// </summary>
    public string ConfMuteStatus { get; set; }

    /// <summary>
    /// Optional conference hold status.
    /// Allowed values depend on system definitions.
    /// </summary>
    public string ConfHoldStatus { get; set; }

    /// <summary>
    /// Optional listen status.
    /// Allowed values depend on system definitions.
    /// </summary>
    public string ListenStatus { get; set; }

    /// <summary>
    /// Optional mute status.
    /// Allowed values depend on system definitions.
    /// </summary>
    public string MuteStatus { get; set; }

    /// <summary>
    /// Optional transcription status.
    /// Allowed values depend on system definitions.
    /// </summary>
    public string TranscribeStatus { get; set; }

    /// <summary>
    /// Optional settings for whispering to a call participant.
    /// </summary>
    public object Whisper { get; set; }

    /// <summary>
    /// Optional SIP request to send during call update.
    /// </summary>
    public SipRequest SipRequest { get; set; }

    /// <summary>
    /// Optional record action settings.
    /// </summary>
    public RecordSettings Record { get; set; }

    /// <summary>
    /// Optional conference participant action.
    /// </summary>
    public ConferenceParticipantAction ConferenceParticipantAction { get; set; }
}
