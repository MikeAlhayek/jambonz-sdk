using Jambonz.Client.V1.Models.Applications;

namespace Jambonz.Client.V1.Contracts;

public interface IApplicationsService
{
    /// <summary>
    /// Create an application.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> CreateAsync(CreateApplication data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an application.
    /// </summary>
    /// <param name="applicationId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(string applicationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve an application.
    /// </summary>
    /// <param name="applicationId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Application> GetAsync(string applicationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List applications.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Application[]> ListAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update an application.
    /// </summary>
    /// <param name="applicationId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateAsync(string applicationId, UpdateApplication data, CancellationToken cancellationToken = default);
}
