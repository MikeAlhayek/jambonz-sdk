namespace Jambonz.Client.V1.Models.Users;

/// <summary>
/// Represents the balance information for the account.
/// </summary>
public sealed class CurrentBalanceInfo
{
    /// <summary>
    /// Currency code (e.g., USD).
    /// </summary>
    public string Currency { get; set; }

    /// <summary>
    /// Current balance amount.
    /// </summary>
    public int Balance { get; set; }

    /// <summary>
    /// Last time the balance was updated.
    /// </summary>
    public DateTime LastUpdatedAt { get; set; }

    /// <summary>
    /// Date and time when the balance was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// ID of the last transaction.
    /// </summary>
    public string LastTransactionId { get; set; }
}
