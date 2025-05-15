namespace Jambonz.Client.V1.Models.Users;

/// <summary>
/// Represents an API key associated with the current user.
/// </summary>
public sealed class CurrentApiKey
{
    /// <summary>
    /// API key token string.
    /// </summary>
    public string Token { get; set; }

    /// <summary>
    /// Last usage date of the API key.
    /// </summary>
    public DateTime LastUsed { get; set; }

    /// <summary>
    /// Date the API key was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }
}
