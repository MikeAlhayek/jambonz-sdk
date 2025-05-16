namespace Jambonz.Client.V1.Models.PhoneNumbers;

/// <summary>
/// Model used to create a new phone number entry associated with a VoIP carrier.
/// </summary>
public sealed class CreatePhoneNumber
{
    /// <summary>
    /// The telephone number to register.
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
