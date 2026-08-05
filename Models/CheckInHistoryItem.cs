using System;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Check-in history for a device.
/// </summary>
public record CheckInHistoryItem
{
    /// <summary>
    /// Device IMEI.
    /// </summary>
    [JsonPropertyName("deviceId")]
    public required string DeviceId { get; init; }

    /// <summary>
    /// Type of client.
    /// </summary>
    [JsonPropertyName("clientType")]
    public required string ClientType { get; init; }

    [JsonPropertyName("result")]
    public required string Result { get; init; }

    [JsonPropertyName("failureType")]
    public required string FailureType { get; init; }

    [JsonPropertyName("timeCompleted")]
    public required DateTimeOffset TimeCompleted { get; init; }
}
