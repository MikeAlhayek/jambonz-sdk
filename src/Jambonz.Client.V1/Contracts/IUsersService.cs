using Jambonz.Client.V1.Models.Users;

namespace Jambonz.Client.V1.Contracts;

public interface IUsersService
{
    Task<bool> CreateAsync(CreateUser data, CancellationToken cancellationToken = default);

    Task<bool> DeleteAsync(string userId, CancellationToken cancellationToken = default);

    Task<User> GetAsync(string userId, CancellationToken cancellationToken = default);

    Task<CurrentUser> GetCurrentAsync(CancellationToken cancellationToken = default);

    Task UpdateAsync(string userId, UpdateUser data, CancellationToken cancellationToken = default);
}
