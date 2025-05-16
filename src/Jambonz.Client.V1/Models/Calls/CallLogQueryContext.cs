namespace Jambonz.Client.V1.Models.Calls;

/// <summary>
/// Represents the query parameters for retrieving call logs with filters and pagination.
/// </summary>
public sealed class CallLogQueryContext
{
    /// <summary>
    /// The page number to retrieve. Required.
    /// </summary>
    public int Page { get; set; } = 1;

    /// <summary>
    /// Number of results to return per page (1–500). Required.
    /// </summary>
    public int Count { get; set; } = 25;

    /// <summary>
    /// Limits results to the past number of days (1–30). Optional.
    /// </summary>
    public int? Days { get; set; }

    /// <summary>
    /// The start datetime for filtering call logs (ISO 8601 format). Optional.
    /// </summary>
    public DateTime? Start { get; set; }

    /// <summary>
    /// The end datetime for filtering call logs (ISO 8601 format). Optional.
    /// </summary>
    public DateTime? End { get; set; }

    /// <summary>
    /// Filter to retrieve only answered or unanswered calls. Optional.
    /// Allowed values: "answered", "unanswered"
    /// </summary>
    public bool? Answered { get; set; }

    /// <summary>
    /// Filters by call direction, such as "inbound" or "outbound". Optional.
    /// </summary>
    public CallDirection? Direction { get; set; }

    /// <summary>
    /// Generic filter for caller ID, callee ID, or Call SID. Optional.
    /// </summary>
    public string Filter { get; set; }
}
