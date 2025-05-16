using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.GoogleCustomVoices;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class GoogleCustomVoicesService : ApiBaseService, IGoogleCustomVoicesService
{
    public GoogleCustomVoicesService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/GoogleCustomVoices", httpClientFactory, options)
    {
    }

    /// <inheritdoc/>
    public Task<GoogleCustomVoice> GetAsync(string voiceId, CancellationToken cancellationToken = default)
        => GetRecordAsync<GoogleCustomVoice>(voiceId, cancellationToken);

    /// <inheritdoc/>
    public Task<GoogleCustomVoice[]> ListAsync(QueryGoogleCustomVoiceContext context = null, CancellationToken cancellationToken = default)
    {
        if (context is not null)
        {
            var queryParameters = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(context.ServiceProviderSid))
            {
                queryParameters.Add("service_provider_sid", ParameterToString(context.ServiceProviderSid));
            }

            if (!string.IsNullOrEmpty(context.AccountSid))
            {
                queryParameters.Add("account_sid", ParameterToString(context.AccountSid));
            }

            if (!string.IsNullOrEmpty(context.SpeechCredentialSid))
            {
                queryParameters.Add("speech_credential_sid", ParameterToString(context.SpeechCredentialSid));
            }

            var uri = QueryHelpers.AddQueryString(UriPrefix, queryParameters);

            return GetByUriAsync<GoogleCustomVoice[]>(uri, cancellationToken);
        }

        return GetByUriAsync<GoogleCustomVoice[]>(UriPrefix, cancellationToken);

    }

    /// <inheritdoc/>
    public Task<GoogleCustomVoiceResult> CreateAsync(CreateGoogleCustomVoice data, CancellationToken cancellationToken = default)
        => CreateRecordAsync<CreateGoogleCustomVoice, GoogleCustomVoiceResult>(data, cancellationToken);

    /// <inheritdoc/>
    public Task UpdateAsync(string voiceId, UpdateGoogleCustomVoice data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(voiceId, data, cancellationToken);

    /// <inheritdoc/>
    public Task<bool> DeleteAsync(string voiceId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(voiceId, cancellationToken);
}
