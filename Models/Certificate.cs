using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Structure for the credentials required to connect to the ETX MQTT Message Exchange.
/// </summary>
public record Certificate
{
    /// <summary>
    /// The string containing the certificate
    /// </summary>
    [JsonPropertyName("cert.pem")]
    [StringLength(4096, MinimumLength = 0)]
    [RegularExpression("^[a-zA-Z0-9~\\+\\-!@#$%^&*()\\`\\[\\]{=};\\\"':,.\\/<>?|\\s]+$")]
    public required string CertPem { get; init; }

    /// <summary>
    /// The string containing the private key
    /// </summary>
    [JsonPropertyName("key.pem")]
    [StringLength(4096, MinimumLength = 0)]
    [RegularExpression("^[a-zA-Z0-9~\\+\\-!@#$%^&*()\\`\\[\\]{=};\\\"':,.\\/<>?|\\s]+$")]
    public required string KeyPem { get; init; }

    /// <summary>
    /// The string containing the CA certificate
    /// </summary>
    [JsonPropertyName("ca.pem")]
    [StringLength(4096, MinimumLength = 0)]
    [RegularExpression("^[a-zA-Z0-9~\\+\\-!@#$%^&*()\\`\\[\\]{=};\\\"':,.\\/<>?|\\s]+$")]
    public required string CaPem { get; init; }

    /// <summary>
    /// The string describing the expiration timestamp of the certificate
    /// </summary>
    [JsonPropertyName("ExpirationTime")]
    public required DateTimeOffset ExpirationTime { get; init; }
}
