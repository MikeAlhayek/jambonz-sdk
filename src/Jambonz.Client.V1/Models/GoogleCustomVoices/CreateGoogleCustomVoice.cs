namespace Jambonz.Client.V1.Models.GoogleCustomVoices;

/// <summary>
/// Represents a request to create a new custom Google voice using a specific speech credential.
/// </summary>
public sealed class CreateGoogleCustomVoice
{
    /// <summary>
    /// The SID of the speech credential to associate with the custom voice.
    /// </summary>
    public string SpeechCredentialSid { get; set; }

    /// <summary>
    /// The name to assign to the custom voice.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The reported usage or purpose of this custom voice.
    /// </summary>
    public string ReportedUsage { get; set; }

    /// <summary>
    /// The model identifier used to create the custom voice.
    /// </summary>
    public string Model { get; set; }
}
