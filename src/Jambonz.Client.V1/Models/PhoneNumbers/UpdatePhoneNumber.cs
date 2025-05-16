namespace Jambonz.Client.V1.Models.PhoneNumbers;

/// <summary>
/// Model used to update an existing phone number entry.
/// </summary>
public sealed class UpdatePhoneNumber
{
    /// <summary>
    /// Unique identifier for the phone number to update (UUID format).
    /// </summary>
    public string PhoneNumberSid { get; set; }

    /// <summary>
    /// The updated telephone number.
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// Identifier for the associated VoIP carrier (UUID format).
    /// </summary>
    public string VoipCarrierSid { get; set; }

    /// <summary>
    /// Optional identifier for the associated account (UUID format).
    /// </summary>
    public string AccountSid { get; set; }

    /// <summary>
    /// Optional identifier for the application handling this number (UUID format).
    /// </summary>
    public string ApplicationSid { get; set; }
}
