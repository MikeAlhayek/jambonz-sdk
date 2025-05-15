using Jambonz.Client.V1.Models.Applications;

namespace Jambonz.Client.V1.Contracts;

public interface IApplicationsService
{
    Task<bool> CreateAsync(CreateApplication data, CancellationToken cancellationToken = default);

    Task<bool> DeleteAsync(string applicationId, CancellationToken cancellationToken = default);

    Task<Application> GetAsync(string applicationId, CancellationToken cancellationToken = default);

    Task<Application[]> GetAsync(CancellationToken cancellationToken = default);

    Task UpdateAsync(string applicationId, UpdateApplication data, CancellationToken cancellationToken = default);
}
