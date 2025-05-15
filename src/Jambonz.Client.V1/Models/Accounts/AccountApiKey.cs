namespace Jambonz.Client.V1.Models.Accounts;

/// <summary>
/// Represents an API key associated with an account.
/// </summary>
public sealed class AccountApiKey
{
    /// <summary>
    /// The unique identifier (SID) of the API key.
    /// </summary>
    public string ApiKeySid { get; set; }

    /// <summary>
    /// The token associated with the API key.
    /// </summary>
    public string Token { get; set; }

    /// <summary>
    /// The unique identifier (SID) of the account this API key belongs to.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// The unique identifier (SID) of the service provider associated with the account.
    /// </summary>
    public string ServiceProviderSid { get; set; }

    /// <summary>
    /// The UTC date and time when the API key will expire.
    /// </summary>
    public DateTime ExpiresAt { get; set; }

    /// <summary>
    /// The UTC date and time when the API key was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// The UTC date and time when the API key was last used.
    /// </summary>
    public DateTime LastUsed { get; set; }
}
