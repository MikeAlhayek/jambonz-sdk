namespace Jambonz.Client.V1.Models.Alerts;

/// <summary>
/// Represents the query parameters used to retrieve alerts with pagination and filtering options.
/// </summary>
public sealed class AlertQueryContext
{
    /// <summary>
    /// The page number to retrieve. Required.
    /// </summary>
    public int Page { get; set; }

    /// <summary>
    /// Number of results to return per page (must be between 1 and 500). Required.
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Limits the result set to alerts from the last N days (1–30). Optional.
    /// </summary>
    public int? Days { get; set; }

    /// <summary>
    /// Start date/time for filtering alerts (ISO 8601 format). Optional.
    /// </summary>
    public DateTime? Start { get; set; }

    /// <summary>
    /// End date/time for filtering alerts (ISO 8601 format). Optional.
    /// </summary>
    public DateTime? End { get; set; }

    /// <summary>
    /// Filter by type of alert. Optional.
    /// </summary>
    public AlertTypes? AlertType { get; set; }
}
