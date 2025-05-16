namespace Jambonz.Client.V1.Models.Speech;

/// <summary>
/// Represents a supported speech language and its available voices.
/// </summary>
public sealed class SupportedSpeech
{
    /// <summary>
    /// The display name of the supported language (e.g., "English (US)").
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The language code value (e.g., "en-US").
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// A list of supported voices for this language.
    /// </summary>
    public List<SupportedVoice> Voices { get; set; }
}
