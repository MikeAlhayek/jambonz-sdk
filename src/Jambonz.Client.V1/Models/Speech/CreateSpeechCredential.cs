namespace Jambonz.Client.V1.Models.Speech;

/// <summary>
/// Represents the data required to create a new speech credential.
/// All properties are optional.
/// </summary>
public sealed class CreateSpeechCredential
{
    /// <summary>
    /// Optional unique identifier for the speech credential.
    /// Format: UUID.
    /// </summary>
    public string SpeechCredentialSid { get; set; }

    /// <summary>
    /// Optional account SID associated with the credential.
    /// Format: UUID.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// Optional vendor name providing the speech service.
    /// Allowed values typically include "google", "aws", "microsoft", etc.
    /// </summary>
    public string Vendor { get; set; }

    /// <summary>
    /// Optional service key used for authenticating with the speech vendor.
    /// </summary>
    public string ServiceKey { get; set; }

    /// <summary>
    /// Optional access key ID for services like AWS.
    /// </summary>
    public string AccessKeyId { get; set; }

    /// <summary>
    /// Optional secret access key for services like AWS.
    /// </summary>
    public string SecretAccessKey { get; set; }

    /// <summary>
    /// Optional AWS region associated with the speech service.
    /// </summary>
    public string AwsRegion { get; set; }

    /// <summary>
    /// Optional timestamp indicating the last time this credential was used.
    /// </summary>
    public DateTime? LastUsed { get; set; }

    /// <summary>
    /// Optional timestamp indicating the last time this credential was tested.
    /// </summary>
    public DateTime? LastTested { get; set; }

    /// <summary>
    /// Optional flag to indicate if this credential is used for text-to-speech (TTS).
    /// </summary>
    public bool? UseForTts { get; set; }

    /// <summary>
    /// Optional flag to indicate if this credential is used for speech-to-text (STT).
    /// </summary>
    public bool? UseForStt { get; set; }

    /// <summary>
    /// Optional flag indicating if TTS testing passed successfully.
    /// </summary>
    public bool? TtsTestedOk { get; set; }

    /// <summary>
    /// Optional flag indicating if STT testing passed successfully.
    /// </summary>
    public bool? SttTestedOk { get; set; }

    /// <summary>
    /// Optional URI for the NVIDIA Riva server used in speech services.
    /// </summary>
    public string RivaServerUri { get; set; }
}
