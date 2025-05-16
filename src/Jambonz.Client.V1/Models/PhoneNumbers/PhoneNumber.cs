namespace Jambonz.Client.V1.Models.PhoneNumbers;

/// <summary>
/// Represents a phone number associated with a VoIP carrier, account, and application.
/// </summary>
public sealed class PhoneNumber
{
    /// <summary>
    /// Unique identifier for the phone number (UUID format).
    /// </summary>
    public string PhoneNumberSid { get; set; }

    /// <summary>
    /// The phone number string.
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// Identifier for the associated VoIP carrier (UUID format).
    /// </summary>
    public string VoipCarrierSid { get; set; }

    /// <summary>
    /// Identifier for the associated account (UUID format).
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// Identifier for the application handling this number (UUID format).
    /// </summary>
    public string ApplicationSid { get; set; }
}
