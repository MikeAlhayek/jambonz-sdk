namespace Jambonz.Client.V1.Models.Users;

public sealed class User
{
    /// <summary>
    /// Unique identifier for the user.
    /// </summary>
    public Guid UserSid { get; set; }

    /// <summary>
    /// Indicates whether the user account is active.
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Full name of the user.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Email address associated with the user.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Authentication provider used by the user (e.g., GitHub).
    /// </summary>
    public string Provider { get; set; }

    /// <summary>
    /// Access scope assigned to the user (e.g., read-only).
    /// </summary>
    public string Scope { get; set; }

    /// <summary>
    /// Indicates whether the user's account is in its original (untouched) state.
    /// </summary>
    public bool Pristine { get; set; }

    /// <summary>
    /// JSON Web Token (JWT) for the user's session.
    /// </summary>
    public string Jwt { get; set; }

    /// <summary>
    /// Identifier for the account associated with the user.
    /// </summary>
    public Guid AccountSid { get; set; }

    /// <summary>
    /// Phone number associated with the user.
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Indicates whether the user's email has been validated.
    /// </summary>
    public bool EmailValidated { get; set; }

    /// <summary>
    /// Indicates whether the user's phone number has been validated.
    /// </summary>
    public bool PhoneValidated { get; set; }

    /// <summary>
    /// Completion level of the user's onboarding tutorial (e.g., 1 = complete).
    /// </summary>
    public int TutorialCompletion { get; set; }
}
