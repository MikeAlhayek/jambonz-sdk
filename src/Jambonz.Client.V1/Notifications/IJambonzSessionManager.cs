
using System.Net.WebSockets;

namespace Jambonz.Client.V1.Notifications;

public interface IJambonzSessionManager
{
    IEnumerable<string> GetIds();

    Task RegisterAsync(string id, WebSocket socket, CancellationToken cancellationToken = default);

    Task RemoveAsync(string id);

    Task<bool> SendVerbAsync(string id, object verb, CancellationToken cancellationToken = default);

    bool TryGetSession(string id, out JambonzSession session);
}
