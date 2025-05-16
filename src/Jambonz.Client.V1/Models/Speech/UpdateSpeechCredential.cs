namespace Jambonz.Client.V1.Models.Speech;

/// <summary>
/// Represents the data used to update specific fields of an existing speech credential.
/// </summary>
public sealed class UpdateSpeechCredential
{
    /// <summary>
    /// Optional flag to indicate if this credential should be used for text-to-speech (TTS).
    /// </summary>
    public bool? UseForTts { get; set; }

    /// <summary>
    /// Optional flag to indicate if this credential should be used for speech-to-text (STT).
    /// </summary>
    public bool? UseForStt { get; set; }
}
