namespace Jambonz.Client.V1.Models.SipGateways;

/// <summary>
/// Represents the request payload to create a new SIP Gateway.
/// </summary>
public sealed class CreateSipGateway
{
    /// <summary>
    /// The UUID of the VoIP carrier that provides this gateway. Required.
    /// </summary>
    public string VoipCarrierSid { get; set; }

    /// <summary>
    /// The IPv4 address of the SIP Gateway. Required.
    /// </summary>
    public string Ipv4 { get; set; }

    /// <summary>
    /// The subnet mask of the gateway IP address. Optional.
    /// </summary>
    public int Netmask { get; set; }

    /// <summary>
    /// The port number for SIP communication. Optional.
    /// </summary>
    public int Port { get; set; }

    /// <summary>
    /// Indicates if the SIP gateway is active. Optional.
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Indicates if this gateway handles inbound SIP traffic. Optional.
    /// </summary>
    public bool Inbound { get; set; }

    /// <summary>
    /// Indicates if this gateway handles outbound SIP traffic. Optional.
    /// </summary>
    public bool Outbound { get; set; }
}
