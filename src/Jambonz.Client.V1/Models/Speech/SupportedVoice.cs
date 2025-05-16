namespace Jambonz.Client.V1.Models.Speech;

/// <summary>
/// Represents an individual voice option for a supported language.
/// </summary>
public sealed class SupportedVoice
{
    /// <summary>
    /// The display name of the voice (e.g., "Standard-A (Female)").
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The unique identifier value of the voice (e.g., "ar-XA-Standard-A").
    /// </summary>
    public string Value { get; set; }
}
