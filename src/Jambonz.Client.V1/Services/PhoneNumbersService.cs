using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Models.PhoneNumbers;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class PhoneNumbersService : ApiBaseService, IPhoneNumbersService
{
    public PhoneNumbersService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/PhoneNumbers", httpClientFactory, options)
    {
    }

    /// <inheritdoc />
    public Task<PhoneNumber[]> ListAsync(CancellationToken cancellationToken = default)
        => GetRecordsAsync<PhoneNumber[]>(cancellationToken);

    /// <inheritdoc />
    public Task<PhoneNumber> GetAsync(string phoneNumberId, CancellationToken cancellationToken = default)
        => GetRecordAsync<PhoneNumber>(phoneNumberId, cancellationToken);

    /// <inheritdoc />
    public Task<bool> CreateAsync(CreatePhoneNumber data, CancellationToken cancellationToken = default)
        => CreateRecordAsync(data, cancellationToken);

    /// <inheritdoc />
    public Task UpdateAsync(string phoneNumberId, UpdatePhoneNumber data, CancellationToken cancellationToken = default)
        => UpdateRecordAsync(phoneNumberId, data, cancellationToken);

    /// <inheritdoc />
    public Task<bool> DeleteAsync(string phoneNumberId, CancellationToken cancellationToken = default)
        => DeleteRecordAsync(phoneNumberId, cancellationToken);
}
