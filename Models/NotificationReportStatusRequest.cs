using System.Text.Json.Serialization;

namespace Verizon.Models;

public record NotificationReportStatusRequest
{
    /// <summary>
    /// The name of a billing account.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// An identifier for a single device.
    /// </summary>
    [JsonPropertyName("device")]
    public required DeviceId Device { get; init; }

    /// <summary>
    /// The type of request.
    /// </summary>
    [JsonPropertyName("requestType")]
    public required string RequestType { get; init; }

    /// <summary>
    /// The time at which the request expires.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestExpirationTime")]
    public string? RequestExpirationTime { get; init; }
}
