namespace Jambonz.Client.V1.Models.Users;

public sealed class CreateUser
{
    /// <summary>
    /// Full name of the user.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Email address of the user.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Indicates whether the user account should be active.
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// If true, the user must change their password upon next login.
    /// </summary>
    public bool? ForceChange { get; set; }

    /// <summary>
    /// Access scope for the user (e.g., admin, read-only).
    /// </summary>
    public string Scope { get; set; }

    /// <summary>
    /// List of permissions assigned to the user.
    /// </summary>
    public IEnumerable<string> Permissions { get; set; }

    /// <summary>
    /// The user's old password, used when changing passwords.
    /// </summary>
    public string OldPassword { get; set; }
}
