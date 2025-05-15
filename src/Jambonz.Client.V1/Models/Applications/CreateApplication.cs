namespace Jambonz.Client.V1.Models.Applications;

/// <summary>
/// Represents the payload to create a voice application, including webhooks and speech configuration.
/// </summary>
public sealed class CreateApplication
{
    /// <summary>
    /// The name of the voice application. This field is required.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The unique identifier (UUID) of the associated account. This field is required.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// The webhook configuration to handle inbound voice calls. This field is required.
    /// </summary>
    public Webhook CallHook { get; set; }

    /// <summary>
    /// The webhook configuration to report call status events. This field is required.
    /// </summary>
    public Webhook CallStatusHook { get; set; }

    /// <summary>
    /// The webhook configuration to handle inbound SMS/MMS messages. Optional.
    /// </summary>
    public Webhook MessagingHook { get; set; }

    /// <summary>
    /// Optional JSON string representing the voice application logic. If provided, CallHook will not be invoked.
    /// </summary>
    public string AppJson { get; set; }

    /// <summary>
    /// The speech synthesis vendor (e.g., Google, Amazon). Optional.
    /// </summary>
    public string SpeechSynthesisVendor { get; set; }

    /// <summary>
    /// The voice to use for speech synthesis. Optional.
    /// </summary>
    public string SpeechSynthesisVoice { get; set; }

    /// <summary>
    /// The speech recognizer vendor (e.g., Google, Azure). Optional.
    /// </summary>
    public string SpeechRecognizerVendor { get; set; }

    /// <summary>
    /// The language used for speech recognition (e.g., "en-US"). Optional.
    /// </summary>
    public string SpeechRecognizerLanguage { get; set; }
}

