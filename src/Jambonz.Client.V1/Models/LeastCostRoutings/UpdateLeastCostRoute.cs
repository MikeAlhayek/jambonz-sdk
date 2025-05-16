namespace Jambonz.Client.V1.Models.CallRouting;

/// <summary>
/// Represents a request to update a Least Cost Route with new routing criteria.
/// </summary>
public sealed class UpdateLeastCostRoute
{
    /// <summary>
    /// The SID of the Least Cost Routing configuration this route belongs to.
    /// Format: UUID.
    /// </summary>
    public string LcrSid { get; set; }

    /// <summary>
    /// The regular expression used to match outbound call phone numbers.
    /// </summary>
    public string Regex { get; set; }

    /// <summary>
    /// The priority of the route. Lower values indicate higher priority.
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// An optional description of the route.
    /// </summary>
    public string Description { get; set; }
}
