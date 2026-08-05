using System;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Callback information of an existing diagnostics subscription.
/// </summary>
public record DeviceDiagnosticsCallback
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
    /// The date and time of when this request was created.
    /// </summary>
    [JsonPropertyName("createdOn")]
    public required DateTimeOffset CreatedOn { get; init; }

    /// <summary>
    /// Your HTTP headers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpHeaders")]
    public object? HttpHeaders { get; init; }
}
