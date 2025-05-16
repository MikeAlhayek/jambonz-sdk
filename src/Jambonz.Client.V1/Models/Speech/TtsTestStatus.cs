using System.Runtime.Serialization;

namespace Jambonz.Client.V1.Models.Speech;

public enum TtsTestStatus
{
    [EnumMember(Value = "not tested")]
    NotTested,

    [EnumMember(Value = "success")]
    Success,

    [EnumMember(Value = "fail")]
    fail,
}
