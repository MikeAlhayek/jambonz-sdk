namespace Jambonz.Client.V1.Models.VoipCarriers;

/// <summary>
/// Represents the payload for updating a VoIP carrier.
/// </summary>
public sealed class UpdateVoipCarrier
{
    /// <summary>
    /// The unique identifier of the VoIP carrier to update (UUID format). Required.
    /// </summary>
    public string VoipCarrierSid { get; set; }

    /// <summary>
    /// The name of the VoIP carrier. Required.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Optional description of the VoIP carrier.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The associated account SID (UUID format). Optional.
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// The associated application SID (UUID format). Optional.
    /// </summary>
    public string ApplicationSid { get; set; }

    /// <summary>
    /// Indicates if E.164 numbers require a leading plus sign. Optional.
    /// </summary>
    public bool E164LeadingPlus { get; set; }

    /// <summary>
    /// Indicates if this carrier requires SIP registration. Optional.
    /// </summary>
    public bool RequiresRegister { get; set; }

    /// <summary>
    /// SIP username for registration (optional).
    /// </summary>
    public string RegisterUsername { get; set; }

    /// <summary>
    /// SIP realm for registration (optional).
    /// </summary>
    public string RegisterSipRealm { get; set; }

    /// <summary>
    /// SIP password for registration (optional).
    /// </summary>
    public string RegisterPassword { get; set; }

    /// <summary>
    /// Optional tech prefix to apply for outbound call attempts.
    /// </summary>
    public string TechPrefix { get; set; }

    /// <summary>
    /// Username for inbound call authentication (optional).
    /// </summary>
    public string InboundAuthUsername { get; set; }

    /// <summary>
    /// Password for inbound call authentication (optional).
    /// </summary>
    public string InboundAuthPassword { get; set; }

    /// <summary>
    /// Diversion header or phone number for outbound calls (optional).
    /// </summary>
    public string Diversion { get; set; }

    /// <summary>
    /// Indicates whether the VoIP carrier is active. Optional.
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// SMPP system ID for outbound messaging (optional).
    /// </summary>
    public string SmppSystemId { get; set; }

    /// <summary>
    /// SMPP password for outbound messaging (optional).
    /// </summary>
    public string SmppPassword { get; set; }

    /// <summary>
    /// SMPP system ID for inbound messaging (optional).
    /// </summary>
    public string SmppInboundSystemId { get; set; }

    /// <summary>
    /// SMPP password for inbound messaging (optional).
    /// </summary>
    public string SmppInboundPassword { get; set; }

    /// <summary>
    /// Interval in seconds for sending SMPP enquire_link messages (optional).
    /// </summary>
    public int SmppEnquireLinkInterval { get; set; }
}
