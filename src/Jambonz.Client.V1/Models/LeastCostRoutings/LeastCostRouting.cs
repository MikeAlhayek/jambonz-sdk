namespace Jambonz.Client.V1.Models.CallRouting;

/// <summary>
/// Represents a Least Cost Routing (LCR) configuration.
/// </summary>
public sealed class LeastCostRouting
{
    /// <summary>
    /// The name of the Least Cost Routing configuration.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The SID of the default carrier set entry to use.
    /// Format: UUID.
    /// </summary>
    public string DefaultCarrierSetEntrySid { get; set; }
}
