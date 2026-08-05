using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A list of license cancellation candidate devices.
/// </summary>
public record V2ListOfLicensesToRemove
{
    /// <summary>
    /// Cancellation candidate devices count.
    /// </summary>
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    /// <summary>
    /// Flag to indicat more devices.
    /// </summary>
    [JsonPropertyName("hasMoreData")]
    public required bool HasMoreData { get; init; }

    /// <summary>
    /// Last update time.
    /// </summary>
    [JsonPropertyName("updateTime")]
    public required string UpdateTime { get; init; }

    /// <summary>
    /// Device IMEI list.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<string> DeviceList { get; init; }
}
