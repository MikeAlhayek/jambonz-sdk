namespace Jambonz.Client.V1.Models.Speech;

/// <summary>
/// Represents credentials used for speech-related services such as TTS and STT.
/// </summary>
public sealed class SpeechCredential
{
    /// <summary>
    /// Unique identifier for the speech credential.
    /// </summary>
    public string SpeechCredentialSid { get; set; }

    /// <summary>
    /// The account SID associated with the credential.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// The vendor providing the speech service (e.g., google, aws, etc.).
    /// </summary>
    public string Vendor { get; set; }

    /// <summary>
    /// The service key used for authentication with the speech vendor.
    /// </summary>
    public string ServiceKey { get; set; }

    /// <summary>
    /// The access key ID for AWS or similar services.
    /// </summary>
    public string AccessKeyId { get; set; }

    /// <summary>
    /// The secret access key for AWS or similar services.
    /// </summary>
    public string SecretAccessKey { get; set; }

    /// <summary>
    /// The AWS region (if applicable) for the speech service.
    /// </summary>
    public string AwsRegion { get; set; }

    /// <summary>
    /// The last time this credential was used.
    /// </summary>
    public DateTime? LastUsed { get; set; }

    /// <summary>
    /// The last time this credential was tested.
    /// </summary>
    public DateTime? LastTested { get; set; }

    /// <summary>
    /// Indicates whether this credential should be used for text-to-speech (TTS).
    /// </summary>
    public bool UseForTts { get; set; }

    /// <summary>
    /// Indicates whether this credential should be used for speech-to-text (STT).
    /// </summary>
    public bool UseForStt { get; set; }

    /// <summary>
    /// Indicates whether the TTS capability of this credential was last tested successfully.
    /// </summary>
    public bool TtsTestedOk { get; set; }

    /// <summary>
    /// Indicates whether the STT capability of this credential was last tested successfully.
    /// </summary>
    public bool SttTestedOk { get; set; }

    /// <summary>
    /// The URI of the Riva server if using NVIDIA Riva for speech processing.
    /// </summary>
    public string RivaServerUri { get; set; }
}
