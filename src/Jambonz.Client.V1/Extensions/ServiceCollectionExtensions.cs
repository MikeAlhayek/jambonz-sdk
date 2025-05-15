using System.Text.Json;
using System.Text.Json.Serialization;
using Jambonz.Client.Core.Json;
using Jambonz.Client.V1.Contracts;
using Jambonz.Client.V1.Handlers;
using Jambonz.Client.V1.Models;
using Jambonz.Client.V1.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Jambonz.Client.V1.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddJambonzClientV1Core(this IServiceCollection services)
    {
        services
            .AddLogging();

        services
            .AddOptions<JambonzJsonSerializerOptions>()
            .Configure(options =>
            {
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.Never; // Closest to MetadataPropertyHandling.Ignore
                options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower;
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumMemberConverterFactory());
            });

        services
            .AddTransient<IConfigureOptions<JambonzOptions>, JambonzOptionsConfiguration>()
            .AddOptions<JambonzOptions>();

        services
            .AddScoped<BearerTokenHandler>()
            .AddHttpClient(JambonzConstants.HttpClientName, (sp, client) =>
            {
                var options = sp.GetRequiredService<IOptions<JambonzOptions>>().Value;

                client.BaseAddress = options.Host;
            }).AddHttpMessageHandler<BearerTokenHandler>();

        return services;
    }

    public static IServiceCollection AddJambonzV1Services(this ServiceCollection services)
    {
        services.AddScoped<IApiKeysService, ApiKeysService>();
        services.AddScoped<IAccountsService, AccountsService>();
        services.AddScoped<IApplicationsService, ApplicationsService>();
        services.AddScoped<IAvailabilitiesService, AvailabilitiesService>();
        services.AddScoped<IClientsService, ClientsService>();
        services.AddScoped<IMicrosoftTeamsTenantsService, MicrosoftTeamsTenantsService>();
        services.AddScoped<IUsersService, UsersService>();
        services.AddScoped<ISbcsService, SbcsService>();
        services.AddScoped<IVoipCarriersService, VoipCarriersService>();
        services.AddScoped<IWebhooksService, WebhooksService>();

        return services;
    }
}
