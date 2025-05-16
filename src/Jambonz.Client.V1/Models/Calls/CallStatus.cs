using System.Runtime.Serialization;

namespace Jambonz.Client.V1.Models.Calls;

public enum CallStatus
{
    [EnumMember(Value = "trying")]
    Trying,

    [EnumMember(Value = "ringing")]
    Ringing,

    [EnumMember(Value = "alerting")]
    Alerting,

    [EnumMember(Value = "in-progress")]
    InProgress,

    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "busy")]
    Busy,

    [EnumMember(Value = "no-answer")]
    NoAnswer,

    [EnumMember(Value = "failed")]
    Failed,

    [EnumMember(Value = "queued")]
    Queued,
}
