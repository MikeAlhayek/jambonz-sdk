namespace Jambonz.Client.V1.Contracts;

public interface IServiceProvidersService
{
    Task<CallTrace> GetCallPcapAsync(string providerId, string callId, CancellationToken cancellationToken = default);

    Task<CallTrace> GetCallTraceAsync(string providerId, string callId, CancellationToken cancellationToken = default);
    Task<PagedResult<CallLogEntry>> GetRecentCallsAsync(string providerId, CallLogQueryContext context, CancellationToken cancellationToken = default);
}
