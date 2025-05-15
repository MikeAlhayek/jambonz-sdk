using System.Runtime.Serialization;

namespace Jambonz.Client.V1.Models;

public enum AlertTypes
{
    [EnumMember(Value = "webhook-failure")]
    WebhookFailure,

    [EnumMember(Value = "webhook-connection-failure")]
    WebhookConnectionFailure,

    [EnumMember(Value = "webhook-auth-failure")]
    WebhookAuthFailure,

    [EnumMember(Value = "no-tts")]
    NoTts,

    [EnumMember(Value = "no-stt")]
    NoStt,

    [EnumMember(Value = "tts-failure")]
    TtsFailure,

    [EnumMember(Value = "stt-failure")]
    SttFailure,

    [EnumMember(Value = "no-carrier")]
    NoCarrier,

    [EnumMember(Value = "call-limit")]
    CallLimit,

    [EnumMember(Value = "device-limit")]
    DeviceLimit,

    [EnumMember(Value = "api-limit")]
    ApiLimit,
}
