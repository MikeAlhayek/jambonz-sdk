namespace Jambonz.Client.V1.Models.Clients;

/// <summary>
/// Represents a registered client with optional capabilities and status.
/// </summary>
public sealed class RegisteredClient
{
    /// <summary>
    /// The name of the registered client.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Optional contact information for the client.
    /// </summary>
    public string Contact { get; set; }

    /// <summary>
    /// Optional expiration time in seconds or epoch (depends on context).
    /// </summary>
    public int ExpiryTime { get; set; }

    /// <summary>
    /// Optional protocol used by the client (e.g., SIP, WebRTC).
    /// </summary>
    public string Protocol { get; set; }

    /// <summary>
    /// Optional flag indicating if direct app calling is allowed (1 = allowed, 0 = not).
    /// </summary>
    public int AllowDirectAppCalling { get; set; }

    /// <summary>
    /// Optional flag indicating if direct queue calling is allowed (1 = allowed, 0 = not).
    /// </summary>
    public int AllowDirectQueueCalling { get; set; }

    /// <summary>
    /// Optional flag indicating if direct user calling is allowed (1 = allowed, 0 = not).
    /// </summary>
    public int AllowDirectUserCalling { get; set; }

    /// <summary>
    /// Optional status of the registered client.
    /// </summary>
    public RegisteredStatus? RegisteredStatus { get; set; }
}

