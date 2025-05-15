using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.Users;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class UsersService : ApiBaseService, IUsersService
{
    public UsersService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/Users", httpClientFactory, options)
    {
    }

    public Task<User> GetAsync(string userId, CancellationToken cancellationToken = default)
        => GetAsync(userId, cancellationToken);

    public Task<bool> CreateAsync(CreateUser data, CancellationToken cancellationToken = default)
        => CreateRecordAsync(data, cancellationToken);

    public Task UpdateAsync(string userId, UpdateUser data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(userId, data, cancellationToken);

    public Task<CurrentUser> GetCurrentAsync(CancellationToken cancellationToken = default)
        => GetRecordAsync<CurrentUser>("me", cancellationToken);

    public Task<bool> DeleteAsync(string userId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(userId, cancellationToken);
}
