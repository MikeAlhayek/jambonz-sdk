namespace Jambonz.Client.V1.Models;

public sealed class JambonzOptions
{
    public string ApiKey { get; set; }

    public string AccountSid { get; set; }

    public string WebhookSecret { get; set; }

    public Uri Host { get; set; }
}
