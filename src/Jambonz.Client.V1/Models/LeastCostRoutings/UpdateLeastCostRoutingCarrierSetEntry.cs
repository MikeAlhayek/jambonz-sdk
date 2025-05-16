namespace Jambonz.Client.V1.Models.CallRouting;

/// <summary>
/// Represents a carrier set entry within a Least Cost Route configuration.
/// </summary>
public sealed class UpdateLeastCostRoutingCarrierSetEntry
{
    /// <summary>
    /// The SID of the Least Cost Route to which this entry belongs.
    /// </summary>
    public string LcrRouteSid { get; set; }

    /// <summary>
    /// The SID of the VoIP carrier assigned to this entry.
    /// </summary>
    public string VoipCarrierSid { get; set; }

    /// <summary>
    /// The priority of this entry within the route. Lower values indicate higher priority.
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// Optional traffic distribution weight for this entry.
    /// </summary>
    public int? Workload { get; set; }
}
