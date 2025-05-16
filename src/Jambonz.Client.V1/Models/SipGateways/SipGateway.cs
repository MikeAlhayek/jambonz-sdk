namespace Jambonz.Client.V1.Models.SipGateways;

/// <summary>
/// Represents a SIP Gateway configuration entry.
/// </summary>
public sealed class SipGateway
{
    /// <summary>
    /// Unique identifier of the SIP Gateway (UUID format).
    /// </summary>
    public string SipGatewaySid { get; set; }

    /// <summary>
    /// The IPv4 address of the SIP Gateway.
    /// </summary>
    public string Ipv4 { get; set; }

    /// <summary>
    /// The port number used by the SIP Gateway.
    /// </summary>
    public int Port { get; set; }

    /// <summary>
    /// The netmask used for the SIP Gateway.
    /// </summary>
    public int Netmask { get; set; }

    /// <summary>
    /// The associated VoIP carrier SID (UUID format).
    /// </summary>
    public string VoipCarrierSid { get; set; }

    /// <summary>
    /// Indicates whether this gateway handles inbound traffic. Optional.
    /// </summary>
    public bool Inbound { get; set; }

    /// <summary>
    /// Indicates whether this gateway handles outbound traffic. Optional.
    /// </summary>
    public bool Outbound { get; set; }
}
