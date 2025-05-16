namespace Jambonz.Client.V1.Models.LeastCostRoutes;

/// <summary>
/// Represents a Least Cost Route used to define routing rules based on number patterns and priority.
/// </summary>
public sealed class LeastCostRoute
{
    /// <summary>
    /// The SID of the Least Cost Routing configuration this route is associated with.
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
    /// A description of the route.
    /// </summary>
    public string Description { get; set; }
}
