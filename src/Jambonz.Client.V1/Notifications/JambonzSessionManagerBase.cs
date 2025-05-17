using System.Collections.Concurrent;
using System.Net.WebSockets;

namespace Jambonz.Client.V1.Notifications;

public abstract class JambonzSessionManagerBase : IJambonzSessionManager
{
    protected readonly ConcurrentDictionary<string, JambonzSession> Sessions = new();

    public virtual bool TryGetSession(string id, out JambonzSession session)
        => Sessions.TryGetValue(id, out session);

    public virtual IEnumerable<string> GetIds()
        => Sessions.Keys;

    public virtual async Task RegisterAsync(string id, WebSocket socket, CancellationToken cancellationToken = default)
    {
        if (Sessions.TryGetValue(id, out var existingSession))
        {
            if (existingSession.IsUsable)
            {
                return;
            }

            await existingSession.DisposeAsync();
        }

        var session = new JambonzSession(id, socket, cancellationToken);
        session.Disconnected += RemoveAsync;
        Sessions[id] = session;
    }

    public virtual async Task<bool> SendVerbAsync(string id, object verb, CancellationToken cancellationToken = default)
    {
        if (Sessions.TryGetValue(id, out var session) && session.IsOpen)
        {
            await session.SendVerbAsync(verb, cancellationToken);
            return true;
        }

        return false;
    }

    public virtual async Task RemoveAsync(string id)
    {
        if (Sessions.TryRemove(id, out var session))
        {
            try
            {
                session.Disconnected -= RemoveAsync;
            }
            catch { }

            await session.CloseAsync(WebSocketCloseStatus.NormalClosure, "Ended");
            await session.DisposeAsync();
        }
    }
}
