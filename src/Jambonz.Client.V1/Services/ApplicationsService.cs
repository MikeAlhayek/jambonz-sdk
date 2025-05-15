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

    public Task<Application> GetAsync(string applicationId, CancellationToken cancellationToken = default)
        => GetRecordAsync<Application>(applicationId, cancellationToken);

    public Task<Application[]> GetAsync(CancellationToken cancellationToken = default)
        => GetRecordsAsync<Application[]>(cancellationToken);

    public Task<bool> CreateAsync(CreateApplication data, CancellationToken cancellationToken = default)
        => CreateRecordAsync(data, cancellationToken);

    public Task UpdateAsync(string userId, UpdateApplication data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(userId, data, cancellationToken);

    public Task<bool> DeleteAsync(string userId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(userId, cancellationToken);
}
