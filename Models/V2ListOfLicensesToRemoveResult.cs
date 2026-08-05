using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// List of created license cancellation devices.
/// </summary>
public record V2ListOfLicensesToRemoveResult
{
    /// <summary>
    /// The number of devices.
    /// </summary>
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    /// <summary>
    /// Device IMEI list.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<string> DeviceList { get; init; }
}
