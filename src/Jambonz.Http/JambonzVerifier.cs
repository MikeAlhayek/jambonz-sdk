using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Jambonz.Http;

public static class JambonzVerifier
{
    public static bool VerifySignature(HttpRequest request, string secret)
    {
        if (!request.Headers.TryGetValue("X-Jambonz-Signature", out var signatureHeader))
        {
            return false;
        }

        if (!request.Body.CanSeek)
        {
            request.EnableBuffering();
        }

        request.Body.Position = 0;
        using var reader = new StreamReader(request.Body, Encoding.UTF8, leaveOpen: true);
        var body = reader.ReadToEnd();
        request.Body.Position = 0;

        var computedHash = ComputeHmacSha256(body, secret);

        return string.Equals(computedHash, signatureHeader, StringComparison.OrdinalIgnoreCase);
    }

    private static string ComputeHmacSha256(string data, string secret)
    {
        using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secret));

        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));

        return Convert.ToHexString(hash).ToLower();
    }
}
