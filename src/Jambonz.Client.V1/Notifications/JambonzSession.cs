using System.Net.WebSockets;
using System.Text;
using System.Text.Json;

namespace Jambonz.Client.V1.Notifications;

public sealed class JambonzSession : IAsyncDisposable
{
    public string Id { get; }
    private readonly WebSocket _socket;
    private readonly CancellationToken _cancellationToken;
    private readonly SemaphoreSlim _sendLock = new(1, 1);
    private readonly List<Func<string, JsonElement, Task>> _listeners = new();
    private bool _isDisposed;

    public event Func<string, Task> Disconnected;

    public JambonzSession(string callId, WebSocket socket, CancellationToken cancellationToken)
    {
        Id = callId;
        _socket = socket;
        _cancellationToken = cancellationToken;
        _ = Task.Run(ListenAsync, cancellationToken);
    }

    public void AddListener(Func<string, JsonElement, Task> listener)
    {
        lock (_listeners)
        {
            _listeners.Add(listener);
        }
    }

    private async Task ListenAsync()
    {
        var buffer = new byte[4096];
        using var messageBuffer = new MemoryStream();

        try
        {
            while (_socket.State == WebSocketState.Open && !_cancellationToken.IsCancellationRequested)
            {
                var segment = new ArraySegment<byte>(buffer);
                var result = await _socket.ReceiveAsync(segment, _cancellationToken);

                if (result.MessageType == WebSocketMessageType.Close)
                {
                    break;
                }

                messageBuffer.Write(buffer, 0, result.Count);

                if (result.EndOfMessage)
                {
                    var message = Encoding.UTF8.GetString(messageBuffer.ToArray());
                    messageBuffer.SetLength(0);

                    var json = JsonDocument.Parse(message).RootElement;

                    List<Func<string, JsonElement, Task>> snapshot;
                    lock (_listeners)
                    {
                        snapshot = _listeners.ToList();
                    }

                    foreach (var listener in snapshot)
                    {
                        await listener.Invoke(Id, json);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Socket read error for id {Id}: {ex.Message}");
        }
        finally
        {
            await Disconnected?.Invoke(Id);
        }
    }

    public async Task SendVerbAsync(object verb, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(verb);
        var buffer = Encoding.UTF8.GetBytes(json);
        var segment = new ArraySegment<byte>(buffer);

        await _sendLock.WaitAsync(cancellationToken);
        try
        {
            if (_socket.State == WebSocketState.Open)
            {
                await _socket.SendAsync(segment, WebSocketMessageType.Text, true, cancellationToken);
            }
        }
        finally
        {
            _sendLock.Release();
        }
    }

    public bool IsUsable =>
        _socket.State == WebSocketState.Open || _socket.State == WebSocketState.None;

    public bool IsOpen => _socket.State == WebSocketState.Open;

    public async Task CloseAsync(WebSocketCloseStatus status, string description)
    {
        if (_socket.State == WebSocketState.Open)
        {
            await _socket.CloseAsync(status, description, CancellationToken.None);
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (_isDisposed)
        {
            return;
        }

        _isDisposed = true;
        _sendLock.Dispose();
        _socket.Dispose();

        await Task.CompletedTask;
    }
}
