namespace Jambonz.Client.V1.Models.VoipCarriers;

/// <summary>
/// Represents the request body for creating or updating a VoIP carrier.
/// </summary>
public sealed class CreateVoipCarrier
{
    /// <summary>
    /// VoIP carrier name. Required.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Optional description of the VoIP carrier.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Associated account SID (UUID format). Optional.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// Associated application SID (UUID format). Optional.
    /// </summary>
    public string ApplicationSid { get; set; }

    /// <summary>
    /// Whether a leading '+' is required on INVITEs to this provider. Optional.
    /// </summary>
    public bool E164LeadingPlus { get; set; }

    /// <summary>
    /// Whether this provider requires REGISTER to receive calls. Optional.
    /// </summary>
    public bool RequiresRegister { get; set; }

    /// <summary>
    /// Whether REGISTER must use TLS protocol. Optional.
    /// </summary>
    public bool RegisterUseTls { get; set; }

    /// <summary>
    /// SIP username for registration (if required). Optional.
    /// </summary>
    public string RegisterUsername { get; set; }

    /// <summary>
    /// SIP realm for registration (if required). Optional.
    /// </summary>
    public string RegisterSipRealm { get; set; }

    /// <summary>
    /// SIP password for registration (if required). Optional.
    /// </summary>
    public string RegisterPassword { get; set; }

    /// <summary>
    /// Username to apply in the From header (optional).
    /// </summary>
    public string RegisterFromUser { get; set; }

    /// <summary>
    /// Domain to apply in the From header (optional).
    /// </summary>
    public string RegisterFromDomain { get; set; }

    /// <summary>
    /// If true, use public IP in Contact header; otherwise, use SIP realm. Optional.
    /// </summary>
    public bool RegisterPublicIpInContact { get; set; }

    /// <summary>
    /// Prefix to be applied to called number for outbound calls. Optional.
    /// </summary>
    public string TechPrefix { get; set; }

    /// <summary>
    /// Username for inbound call authentication. Optional.
    /// </summary>
    public string InboundAuthUsername { get; set; }

    /// <summary>
    /// Password for inbound call authentication. Optional.
    /// </summary>
    public string InboundAuthPassword { get; set; }

    /// <summary>
    /// Diversion header or number to apply to outbound calls. Optional.
    /// </summary>
    public string Diversion { get; set; }
}
