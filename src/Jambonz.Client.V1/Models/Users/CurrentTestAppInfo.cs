namespace Jambonz.Client.V1.Models.Users;

/// <summary>
/// Represents the test application configuration.
/// </summary>
public sealed class CurrentTestAppInfo
{
    /// <summary>
    /// Unique application identifier.
    /// </summary>
    public string ApplicationSid { get; set; }

    /// <summary>
    /// Application name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Service provider identifier.
    /// </summary>
    public string ServiceProviderSid { get; set; }

    /// <summary>
    /// Associated account identifier.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// Hook SID for call events.
    /// </summary>
    public string CallHookSid { get; set; }

    /// <summary>
    /// Hook SID for call status changes.
    /// </summary>
    public string CallStatusHookSid { get; set; }

    /// <summary>
    /// Hook SID for messaging events.
    /// </summary>
    public string MessagingHookSid { get; set; }

    /// <summary>
    /// Vendor for speech synthesis.
    /// </summary>
    public string SpeechSynthesisVendor { get; set; }

    /// <summary>
    /// Language used for speech synthesis.
    /// </summary>
    public string SpeechSynthesisLanguage { get; set; }

    /// <summary>
    /// Voice used for speech synthesis.
    /// </summary>
    public string SpeechSynthesisVoice { get; set; }

    /// <summary>
    /// Vendor for speech recognition.
    /// </summary>
    public string SpeechRecognizerVendor { get; set; }

    /// <summary>
    /// Language used for speech recognition.
    /// </summary>
    public string SpeechRecognizerLanguage { get; set; }
}
