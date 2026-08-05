using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request to list of network connection events for a device during a specified time period.
/// </summary>
public record DeviceConnectionListRequest
{
    /// <summary>
    /// An identifier for a single device.
    /// </summary>
    [JsonPropertyName("deviceId")]
    public required DeviceId DeviceId { get; init; }

    /// <summary>
    /// The earliest date and time for which you want connection events.
    /// </summary>
    [JsonPropertyName("earliest")]
    public required string Earliest { get; init; }

    /// <summary>
    /// The last date and time for which you want connection events.
    /// </summary>
    [JsonPropertyName("latest")]
    public required string Latest { get; init; }
}
