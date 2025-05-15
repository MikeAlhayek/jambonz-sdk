using System.Net;
using System.Net.Http.Headers;
using Jambonz.Client.V1.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Handlers;

public sealed class BearerTokenHandler : DelegatingHandler
{
    private static readonly MediaTypeWithQualityHeaderValue _jsonHeader = new("application/json");

    private readonly ILogger _logger;
    private readonly JambonzOptions _options;

    public BearerTokenHandler(
        IOptions<JambonzOptions> options,
        ILogger<BearerTokenHandler> logger)
    {
        _options = options.Value;
        _logger = logger;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Accept.Add(_jsonHeader);

        if (!string.IsNullOrEmpty(_options.ApiKey))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _options.ApiKey);
        }

        var response = await base.SendAsync(request, cancellationToken);

        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
            throw new UnauthorizedAccessException("Refresh access token failed. User re-authentication may be required.");
        }
        else if ((int)response.StatusCode >= 400 && _logger.IsEnabled(LogLevel.Error))
        {
            var body = await response.Content.ReadAsStringAsync(cancellationToken);

            _logger.LogError("Failed to call PureCloud API. {Content}", body);
        }

        return response;
    }
}
