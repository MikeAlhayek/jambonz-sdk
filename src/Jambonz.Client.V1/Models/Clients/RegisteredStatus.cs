using System.Runtime.Serialization;

namespace Jambonz.Client.V1.Models.Clients;

/// <summary>
/// Enum representing the registration status of a client.
/// </summary>
public enum RegisteredStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "inactive")]
    Inactive,
}

