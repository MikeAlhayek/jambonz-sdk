namespace Jambonz.Client.V1.Models.GoogleCustomVoices;

/// <summary>
/// Represents a query context for filtering Google custom voices by service provider, account, or speech credential.
/// </summary>
public sealed class QueryGoogleCustomVoiceContext
{
    /// <summary>
    /// Optional SID of the service provider to filter voices by.
    /// </summary>
    public string ServiceProviderSid { get; set; }

    /// <summary>
    /// Optional SID of the account to filter voices by.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// Optional SID of the speech credential to filter voices by.
    /// </summary>
    public string SpeechCredentialSid { get; set; }
}
