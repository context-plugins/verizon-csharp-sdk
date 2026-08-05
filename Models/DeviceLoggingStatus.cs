using System;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Device logging status information.
/// </summary>
public record DeviceLoggingStatus
{
    /// <summary>
    /// Device IMEI.
    /// </summary>
    [JsonPropertyName("deviceId")]
    public required string DeviceId { get; init; }

    /// <summary>
    /// The date when device logging expires.
    /// </summary>
    [JsonPropertyName("expiryDate")]
    public required DateTimeOffset ExpiryDate { get; init; }
}
