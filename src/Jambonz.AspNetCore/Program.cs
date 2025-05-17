using Jambonz.Http.Endpoints;

var builder = WebApplication.CreateBuilder();

var app = builder.Build();

app.AddCallWebhookEndpoint()
   .AddTextToSpeechWebhookEndpoint()
   .AddLargeLanguageModelWebhookEndpoint();

await app.RunAsync();
