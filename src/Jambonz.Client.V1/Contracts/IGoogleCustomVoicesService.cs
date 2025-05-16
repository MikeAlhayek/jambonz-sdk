using Jambonz.Client.V1.Models.GoogleCustomVoices;

namespace Jambonz.Client.V1.Contracts;

public interface IGoogleCustomVoicesService
{
    /// <summary>
    /// Create a Google custom voice.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<GoogleCustomVoiceResult> CreateAsync(CreateGoogleCustomVoice data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a Google custom voice.
    /// </summary>
    /// <param name="voiceId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(string voiceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve google custom voice.
    /// </summary>
    /// <param name="voiceId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<GoogleCustomVoice> GetAsync(string voiceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List google custom voices.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<GoogleCustomVoice[]> ListAsync(QueryGoogleCustomVoiceContext context = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Google custom voice.
    /// </summary>
    /// <param name="voiceId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateAsync(string voiceId, UpdateGoogleCustomVoice data, CancellationToken cancellationToken = default);
}
