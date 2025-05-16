using Jambonz.Client.V1.Models.PhoneNumbers;

namespace Jambonz.Client.V1.Contracts;

internal interface IPhoneNumbersService
{
    /// <summary>
    /// Provision a phone number into inventory from a Voip Carrier.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> CreateAsync(CreatePhoneNumber data, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a phone number.
    /// </summary>
    /// <param name="phoneNumberId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(string phoneNumberId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve phone number.
    /// </summary>
    /// <param name="phoneNumberId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<PhoneNumber> GetAsync(string phoneNumberId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List phone numbers.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<PhoneNumber[]> ListAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update phone number.
    /// </summary>
    /// <param name="phoneNumberId"></param>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateAsync(string phoneNumberId, UpdatePhoneNumber data, CancellationToken cancellationToken = default);
}
