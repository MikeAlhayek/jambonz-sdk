namespace Jambonz.Client.V1.Models.Applications;

/// <summary>
/// Represents an application configuration including webhooks for voice, status, and messaging events.
/// </summary>
public sealed class Application
{
    /// <summary>
    /// The unique identifier (UUID) of the application.
    /// </summary>
    public string ApplicationSid { get; set; }

    /// <summary>
    /// The name of the application.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The unique identifier (UUID) of the associated account.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// The webhook configuration for handling inbound voice calls. Optional.
    /// </summary>
    public Webhook CallHook { get; set; }

    /// <summary>
    /// The webhook configuration for reporting call status events. Optional.
    /// </summary>
    public Webhook CallStatusHook { get; set; }

    /// <summary>
    /// The webhook configuration for handling inbound SMS/MMS messages. Optional.
    /// </summary>
    public Webhook MessagingHook { get; set; }

    /// <summary>
    /// The speech synthesis vendor (e.g., Google, Amazon). Optional.
    /// </summary>
    public string SpeechSynthesisVendor { get; set; }

    /// <summary>
    /// The voice to use for speech synthesis (e.g., "en-US-Wavenet-D"). Optional.
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
