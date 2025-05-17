namespace Jambonz.Client.V1.Models.LeastCostRoutings;

/// <summary>
/// Represents a request to update a Least Cost Route configuration.
/// </summary>
public sealed class UpdateLeastCostRoutingRoute
{
    /// <summary>
    /// The SID of the Least Cost Routing configuration this route belongs to.
    /// </summary>
    public string LcrSid { get; set; }

    /// <summary>
    /// The priority of the route. Lower values represent higher priority.
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// The regular expression used to match outbound call phone numbers.
    /// </summary>
    public string Regex { get; set; }

    /// <summary>
    /// An optional description of the route.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Optional list of carrier set entries associated with this route.
    /// </summary>
    public IEnumerable<LeastCostRoutingCarrierSetEntry> LcrCarrierSetEntries { get; set; }

    /// <summary>
    /// The SID of the Least Cost Route to update.
    /// </summary>
    public string LcrRouteSid { get; set; }

    /// <summary>
    /// The SID of the VoIP carrier assigned to this route.
    /// </summary>
    public string VoipCarrierSid { get; set; }

    /// <summary>
    /// The priority of this route within the carrier's routing group.
    /// </summary>
    public int PriorityWithinCarrier { get; set; }

    /// <summary>
    /// Optional traffic distribution weight for this route.
    /// </summary>
    public int? Workload { get; set; }
}
