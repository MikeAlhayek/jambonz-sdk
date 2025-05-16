namespace Jambonz.Client.V1.Models.CallRouting;

/// <summary>
/// Represents a request to update a Least Cost Routing (LCR) configuration.
/// </summary>
public sealed class UpdateLeastCostRouting
{
    /// <summary>
    /// The updated name of the Least Cost Routing configuration.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Optional updated SID of the default carrier set entry.
    /// Format: UUID.
    /// </summary>
    public string DefaultCarrierSetEntrySid { get; set; }
}
