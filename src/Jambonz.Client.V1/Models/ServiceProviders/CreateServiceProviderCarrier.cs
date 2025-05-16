namespace Jambonz.Client.V1.Models.ServiceProviders;

/// <summary>
/// Request model for creating a VoIP service provider carrier.
/// </summary>
public sealed class CreateServiceProviderCarrier
{
    /// <summary>
    /// Unique identifier of the VoIP carrier (UUID format). Required.
    /// </summary>
    public string VoipCarrierSid { get; set; }

    /// <summary>
    /// Name of the VoIP carrier. Required.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Description of the carrier. Optional.
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
    /// Whether a leading '+' is required in E.164 numbers. Optional.
    /// </summary>
    public bool E164LeadingPlus { get; set; }

    /// <summary>
    /// Indicates if the provider requires SIP registration. Optional.
    /// </summary>
    public bool RequiresRegister { get; set; }

    /// <summary>
    /// SIP username used for registration. Optional.
    /// </summary>
    public string RegisterUsername { get; set; }

    /// <summary>
    /// SIP realm used for registration. Optional.
    /// </summary>
    public string RegisterSipRealm { get; set; }

    /// <summary>
    /// SIP password used for registration. Optional.
    /// </summary>
    public string RegisterPassword { get; set; }

    /// <summary>
    /// Technical prefix for outbound calls. Optional.
    /// </summary>
    public string TechPrefix { get; set; }

    /// <summary>
    /// Username used for authenticating inbound calls. Optional.
    /// </summary>
    public string InboundAuthUsername { get; set; }

    /// <summary>
    /// Password used for authenticating inbound calls. Optional.
    /// </summary>
    public string InboundAuthPassword { get; set; }

    /// <summary>
    /// Diversion header or phone number for outbound calls. Optional.
    /// </summary>
    public string Diversion { get; set; }

    /// <summary>
    /// Indicates if the carrier is active. Optional.
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// SMPP system ID for messaging. Optional.
    /// </summary>
    public string SmppSystemId { get; set; }

    /// <summary>
    /// SMPP password for messaging. Optional.
    /// </summary>
    public string SmppPassword { get; set; }

    /// <summary>
    /// SMPP system ID for inbound messaging. Optional.
    /// </summary>
    public string SmppInboundSystemId { get; set; }

    /// <summary>
    /// SMPP password for inbound messaging. Optional.
    /// </summary>
    public string SmppInboundPassword { get; set; }

    /// <summary>
    /// Interval for SMPP enquire link messages in seconds. Optional.
    /// </summary>
    public int SmppEnquireLinkInterval { get; set; }
}
