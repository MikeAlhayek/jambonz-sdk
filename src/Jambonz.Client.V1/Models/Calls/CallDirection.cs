using System.Runtime.Serialization;

namespace Jambonz.Client.V1.Models.Calls;

public enum CallDirection
{
    [EnumMember(Value = "inbound")]
    Inbound,

    [EnumMember(Value = "outbound")]
    Outbound,
}
