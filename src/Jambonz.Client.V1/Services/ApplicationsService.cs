using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.Applications;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class ApplicationsService : ApiBaseService, IApplicationsService
{
    public ApplicationsService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/Applications", httpClientFactory, options)
    {
    }

    /// <inheritdoc/>
    public Task<Application> GetAsync(string applicationId, CancellationToken cancellationToken = default)
        => GetRecordAsync<Application>(applicationId, cancellationToken);

    /// <inheritdoc/>
    public Task<Application[]> ListAsync(CancellationToken cancellationToken = default)
        => GetRecordsAsync<Application[]>(cancellationToken);

    /// <inheritdoc/>
    public Task<bool> CreateAsync(CreateApplication data, CancellationToken cancellationToken = default)
        => CreateRecordAsync(data, cancellationToken);

    /// <inheritdoc/>
    public Task UpdateAsync(string userId, UpdateApplication data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(userId, data, cancellationToken);

    /// <inheritdoc/>
    public Task<bool> DeleteAsync(string userId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(userId, cancellationToken);
}
