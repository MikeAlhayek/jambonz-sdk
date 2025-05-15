namespace Jambonz.Client.V1.Models.Users;

/// <summary>
/// Represents the current user and associated data in the system.
/// </summary>
public sealed class CurrentUser
{
    /// <summary>
    /// User information.
    /// </summary>
    public CurrentUserInfo User { get; set; }

    /// <summary>
    /// Account information.
    /// </summary>
    public CurrentAccountInfo Account { get; set; }

    /// <summary>
    /// Test application configuration.
    /// </summary>
    public CurrentTestAppInfo TestApp { get; set; }

    /// <summary>
    /// Account balance details.
    /// </summary>
    public CurrentBalanceInfo Balance { get; set; }

    /// <summary>
    /// System capacity limits.
    /// </summary>
    public CurrentCapacitiesInfo Capacities { get; set; }

    /// <summary>
    /// List of API keys.
    /// </summary>
    public IEnumerable<CurrentApiKey> ApiKeys { get; set; }

    /// <summary>
    /// List of available products.
    /// </summary>
    public IEnumerable<CurrentProduct> Products { get; set; }
}
