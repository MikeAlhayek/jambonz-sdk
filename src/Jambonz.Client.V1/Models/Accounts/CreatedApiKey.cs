namespace Jambonz.Client.V1.Models.Accounts;

public sealed class CreatedApiKey
{
    /// <summary>
    /// The unique identifier (SID) of the API key.
    /// </summary>
    public string Sid { get; set; }

    /// <summary>
    /// The token associated with the API key.
    /// </summary>
    public string Token { get; set; }
}
