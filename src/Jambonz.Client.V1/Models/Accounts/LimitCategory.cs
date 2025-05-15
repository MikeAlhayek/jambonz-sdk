using System.Runtime.Serialization;

namespace Jambonz.Client.V1.Models.Accounts;

public enum LimitCategory
{
    [EnumMember(Value = "voice_call_session")]
    VoiceCallSession,

    [EnumMember(Value = "api_limit")]
    ApiLimit,

    [EnumMember(Value = "devices")]
    Devices,
}
