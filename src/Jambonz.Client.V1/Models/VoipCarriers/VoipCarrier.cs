using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jambonz.Client.V1.Models.VoipCarriers;

/// <summary>
/// Represents a VoIP carrier configuration with optional registration and SMPP settings.
/// </summary>
public sealed class VoipCarrier
{
    /// <summary>
    /// The unique identifier of the VoIP carrier (UUID format).
    /// </summary>
    public string VoipCarrierSid { get; set; }

    /// <summary>
    /// The name of the VoIP carrier.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// A description of the carrier (optional).
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The associated account SID (UUID format, optional).
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// The associated application SID (UUID format, optional).
    /// </summary>
    public string ApplicationSid { get; set; }

    /// <summary>
    /// Indicates if E.164 numbers require a leading plus sign (optional).
    /// </summary>
    public bool E164LeadingPlus { get; set; }

    /// <summary>
    /// Indicates if the carrier requires SIP registration (optional).
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
    /// Optional tech prefix for call routing.
    /// </summary>
    public string TechPrefix { get; set; }

    /// <summary>
    /// Inbound authentication username (optional).
    /// </summary>
    public string InboundAuthUsername { get; set; }

    /// <summary>
    /// Inbound authentication password (optional).
    /// </summary>
    public string InboundAuthPassword { get; set; }

    /// <summary>
    /// Optional diversion header setting.
    /// </summary>
    public string Diversion { get; set; }

    /// <summary>
    /// Indicates if the carrier is active (optional).
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
    /// Interval (in seconds) between SMPP enquire_link messages (optional).
    /// </summary>
    public int SmppEnquireLinkInterval { get; set; }
}
