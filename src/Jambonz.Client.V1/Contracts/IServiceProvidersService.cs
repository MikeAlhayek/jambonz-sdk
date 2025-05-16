using Jambonz.Client.V1.Models.Accounts;
using Jambonz.Client.V1.Models.CallRouting;
using Jambonz.Client.V1.Models.Calls;
using Jambonz.Client.V1.Models.ServiceProviders;
using Jambonz.Client.V1.Models.VoipCarriers;

namespace Jambonz.Client.V1.Contracts;

public interface IServiceProvidersService
{
    /// <summary>
    /// Add a Carrier to a service provider using a template.
    /// </summary>
    /// <param name="providerId"></param>
    /// <param name="carrierId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<CreatedCarrier> AddCarrierAsync(string providerId, string carrierId, CreateServiceProviderCarrier data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create service provider.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> CreateAsync(CreateServiceProvider data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a carrier.
    /// </summary>
    /// <param name="providerId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<CreatedCarrier> CreateCarrierAsync(string providerId, CreateServiceProviderCarrier data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update service provider.
    /// </summary>
    /// <param name="providerId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateAsync(string providerId, UpdateServiceProvider data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a service provider.
    /// </summary>
    /// <param name="providerId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(string providerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve service provider.
    /// </summary>
    /// <param name="providerId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ServiceProvider> GetAsync(string providerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve pcap for a call.
    /// </summary>
    /// <param name="providerId"></param>
    /// <param name="callId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<CallTrace> GetCallPcapAsync(string providerId, string callId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve jaeger trace detail for a call.
    /// </summary>
    /// <param name="providerId"></param>
    /// <param name="callId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<CallTrace> GetCallTraceAsync(string providerId, string callId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all carriers for a service provider.
    /// </summary>
    /// <param name="providerId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<VoipCarrier[]> ListCarriersAsync(string providerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve recent calls for an account.
    /// </summary>
    /// <param name="providerId"></param>
    /// <param name="context"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<PagedResult<CallLogEntry>> PageRecentCallsAsync(string providerId, CallLogQueryContext context, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve call capacity and other limits from the service provider.
    /// </summary>
    /// <param name="providerId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<AccountLimitResult[]> ListLimitsAsync(string providerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a limit for a service provider.
    /// </summary>
    /// <param name="providerId"></param>
    /// <param name="category"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<LimitResult> CreateLimitAsync(string providerId, LimitCategory? category = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// List all Least Cost Routings for a service provider.
    /// </summary>
    /// <param name="providerId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ServiceProviderLeastCostRouting[]> ListLeastCostRoutingAsync(string providerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a Lest cost routing for a service provider.
    /// </summary>
    /// <param name="providerId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<LeastCostRoutingResult> CreateLeastCostRoutingAsync(string providerId, CreateLeastCostRouting data, CancellationToken cancellationToken = default);
}
