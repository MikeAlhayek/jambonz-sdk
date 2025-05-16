namespace Jambonz.Client.V1.Models.Speech;

/// <summary>
/// Represents a request to synthesize text into audio using a specific speech credential and voice.
/// </summary>
public sealed class Synthesize
{
    /// <summary>
    /// The SID of the speech credential to use for synthesis.
    /// </summary>
    public string SpeechCredentialSid { get; set; }

    /// <summary>
    /// The text to convert into audio.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// The language code of the input text (e.g., "en-US").
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// The identifier of the voice to use for synthesis.
    /// </summary>
    public string Voice { get; set; }

    /// <summary>
    /// Optional flag to indicate whether the audio should be encoded as MP3.
    /// </summary>
    public bool? EncodingMp3 { get; set; }
}
