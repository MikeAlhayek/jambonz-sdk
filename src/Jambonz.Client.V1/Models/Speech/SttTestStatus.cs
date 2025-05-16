using System.Runtime.Serialization;

namespace Jambonz.Client.V1.Models.Speech;

public enum SttTestStatus
{
    [EnumMember(Value = "success")]
    Success,

    [EnumMember(Value = "fail")]
    fail,
}
