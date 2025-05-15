namespace Jambonz.Client.V1.Models.Users;

/// <summary>
/// Represents system usage and registration capacity limits.
/// </summary>
public sealed class CurrentCapacitiesInfo
{
    /// <summary>
    /// Date when the current limits started.
    /// </summary>
    public DateTime EffectiveStartDate { get; set; }

    /// <summary>
    /// Date when the current limits expire.
    /// </summary>
    public DateTime EffectiveEndDate { get; set; }

    /// <summary>
    /// Maximum allowed concurrent sessions.
    /// </summary>
    public int LimitSessions { get; set; }

    /// <summary>
    /// Maximum allowed registrations.
    /// </summary>
    public int LimitRegistrations { get; set; }
}
