namespace Jambonz.Client.V1.Models.CallRouting;

/// <summary>
/// Represents a service provider's Least Cost Routing (LCR) configuration.
/// </summary>
public sealed class ServiceProviderLeastCostRouting
{
    /// <summary>
    /// The name of the Least Cost Routing configuration.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The SID of the default carrier set entry used by the LCR.
    /// Format: UUID.
    /// </summary>
    public string DefaultCarrierSetEntrySid { get; set; }
}
