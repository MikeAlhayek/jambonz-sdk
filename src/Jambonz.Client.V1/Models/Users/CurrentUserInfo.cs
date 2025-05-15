namespace Jambonz.Client.V1.Models.Users;

/// <summary>
/// Contains information about the current user.
/// </summary>
public sealed class CurrentUserInfo
{
    /// <summary>
    /// Unique identifier for the user.
    /// </summary>
    public string UserSid { get; set; }

    /// <summary>
    /// Full name of the user.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Email address of the user.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Phone number of the user.
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Service provider identifier.
    /// </summary>
    public string ServiceProviderSid { get; set; }

    /// <summary>
    /// Indicates if the user must change their password.
    /// </summary>
    public bool ForceChange { get; set; }

    /// <summary>
    /// External identity provider (e.g., GitHub).
    /// </summary>
    public string Provider { get; set; }

    /// <summary>
    /// Identifier from the external provider.
    /// </summary>
    public string ProviderUserId { get; set; }

    /// <summary>
    /// Permission scope assigned to the user.
    /// </summary>
    public string Scope { get; set; }

    /// <summary>
    /// Indicates if the email address has been validated.
    /// </summary>
    public bool EmailValidated { get; set; }

    /// <summary>
    /// Indicates if the phone number has been validated.
    /// </summary>
    public string PhoneValidated { get; set; }
}
