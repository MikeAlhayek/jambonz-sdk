using System.Net.WebSockets;
using Jambonz.Client.V1.Models;
using Jambonz.Client.V1.Notifications;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Jambonz.Http.Endpoints;

public static class CallWebhookEndpoint
{
    public static IEndpointRouteBuilder AddCallWebhookEndpoint(this IEndpointRouteBuilder builder)
    {
        builder.MapPost("jambonez/webhook/call", HandleAsync)
            .AllowAnonymous()
            .DisableAntiforgery();

        return builder;
    }

    private static async Task<IResult> HandleAsync(
        HttpRequest request,
        IOptions<JambonzOptions> options,
        [FromKeyedServices("call")] IJambonzSessionManager sessionManager,
        CancellationToken cancellationToken)
    {
        if (!JambonzVerifier.VerifySignature(request, options.Value.WebhookSecret))
        {
            return Results.Unauthorized();
        }

        if (!request.Query.TryGetValue("call_id", out var callIdValues))
        {
            return Results.BadRequest("Missing call_id");
        }

        if (!request.HttpContext.WebSockets.IsWebSocketRequest)
        {
            return Results.BadRequest("Expected WebSocket request");
        }

        var webSocket = await request.HttpContext.WebSockets.AcceptWebSocketAsync();

        var callId = callIdValues.ToString();

        await sessionManager.RegisterAsync(callId, webSocket, cancellationToken);

        // Wait for socket close and clean up session.
        await WaitForSocketCloseAsync(webSocket, cancellationToken);

        await sessionManager.RemoveAsync(callId);

        return Results.Ok();
    }

    private static async Task WaitForSocketCloseAsync(WebSocket socket, CancellationToken token)
    {
        var buffer = new byte[1024];

        while (socket.State == WebSocketState.Open && !token.IsCancellationRequested)
        {
            var result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), token);

            if (result.MessageType == WebSocketMessageType.Close)
            {
                break;
            }
        }
    }
}
