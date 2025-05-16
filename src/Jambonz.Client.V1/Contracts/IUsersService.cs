using Jambonz.Client.V1.Models.Users;

namespace Jambonz.Client.V1.Contracts;

public interface IUsersService
{
    /// <summary>
    /// Create a user.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> CreateAsync(CreateUser data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a user.
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a user.
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<User> GetAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve current logged user.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<CurrentUser> GetCurrentAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user.
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateAsync(string userId, UpdateUser data, CancellationToken cancellationToken = default);
}
