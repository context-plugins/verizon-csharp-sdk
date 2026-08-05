using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Specifies the callback service that is being subscribed to and the URL where the listening service is running.
/// </summary>
public record CallbackRegistrationRequest
{
    /// <summary>
    /// The name of the billing account for which callback messages will be sent. Format: "##########-#####".
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public required string ServiceName { get; init; }

    /// <summary>
    /// The URL for your web server.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; init; }

    /// <summary>
    /// Your HTTP headers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpHeaders")]
    public object? HttpHeaders { get; init; }
}
