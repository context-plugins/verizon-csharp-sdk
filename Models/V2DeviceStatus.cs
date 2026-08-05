using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Device with id in IMEI.
/// </summary>
public record V2DeviceStatus
{
    /// <summary>
    /// Device IMEI.
    /// </summary>
    [JsonPropertyName("deviceId")]
    public required string DeviceId { get; init; }

    /// <summary>
    /// Success or failure.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    /// <summary>
    /// Result reason.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultReason")]
    public string? ResultReason { get; init; }
}
