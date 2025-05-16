namespace Jambonz.Client.V1.Models.GoogleCustomVoices;

/// <summary>
/// Represents a custom Google voice configuration linked to a specific speech credential.
/// </summary>
public sealed class GoogleCustomVoice
{
    /// <summary>
    /// The SID of the speech credential associated with this custom voice.
    /// </summary>
    public string SpeechCredentialSid { get; set; }

    /// <summary>
    /// The name of the custom voice.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The reported usage of the voice (e.g., application purpose or usage notes).
    /// </summary>
    public string ReportedUsage { get; set; }

    /// <summary>
    /// The model identifier used for this custom voice.
    /// </summary>
    public string Model { get; set; }
}
