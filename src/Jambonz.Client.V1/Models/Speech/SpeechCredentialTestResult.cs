namespace Jambonz.Client.V1.Models.Speech;

public sealed class SpeechCredentialTestResult
{
    public TtsTestStatus Tts { get; set; }

    public SttTestStatus Stt { get; set; }
}
