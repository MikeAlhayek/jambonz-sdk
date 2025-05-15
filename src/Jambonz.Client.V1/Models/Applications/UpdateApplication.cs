namespace Jambonz.Client.V1.Models.Applications;

/// <summary>
/// Represents the payload to update a voice application, including optional webhooks and speech settings.
/// </summary>
public sealed class UpdateApplication
{
    /// <summary>
    /// The unique identifier (UUID) of the application. Required.
    /// </summary>
    public string ApplicationSid { get; set; }

    /// <summary>
    /// The name of the voice application. Required.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The unique identifier (UUID) of the account. Required.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// Webhook configuration for inbound voice calls. Optional.
    /// </summary>
    public Webhook CallHook { get; set; }

    /// <summary>
    /// Webhook configuration for reporting call status events. Optional.
    /// </summary>
    public Webhook CallStatusHook { get; set; }

    /// <summary>
    /// Webhook configuration for inbound SMS/MMS messages. Optional.
    /// </summary>
    public Webhook MessagingHook { get; set; }

    /// <summary>
    /// Speech synthesis vendor (e.g., Google, Amazon). Optional.
    /// </summary>
    public string SpeechSynthesisVendor { get; set; }

    /// <summary>
    /// Voice to be used for speech synthesis (e.g., en-US-Wavenet-D). Optional.
    /// </summary>
    public string SpeechSynthesisVoice { get; set; }

    /// <summary>
    /// Speech recognition vendor (e.g., Google, Azure). Optional.
    /// </summary>
    public string SpeechRecognizerVendor { get; set; }

    /// <summary>
    /// Language for speech recognition (e.g., en-US). Optional.
    /// </summary>
    public string SpeechRecognizerLanguage { get; set; }
}

