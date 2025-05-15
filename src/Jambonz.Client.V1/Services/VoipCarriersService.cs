using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Services;

public sealed class VoipCarriersService : ApiBaseService, IVoipCarriersService
{
    public VoipCarriersService(
        IHttpClientFactory httpClientFactory,
        IOptions<JambonzJsonSerializerOptions> options)
        : base("v1/VoipCarriers", httpClientFactory, options)
    {
    }
}
