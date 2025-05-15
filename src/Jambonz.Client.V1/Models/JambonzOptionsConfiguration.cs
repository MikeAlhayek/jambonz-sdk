using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Models;

public sealed class JambonzOptionsConfiguration : IConfigureOptions<JambonzOptions>
{
    private readonly IConfiguration _configuration;

    public JambonzOptionsConfiguration(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(JambonzOptions options)
    {
        _configuration.GetSection("Jambonez").Bind(options);
    }
}
