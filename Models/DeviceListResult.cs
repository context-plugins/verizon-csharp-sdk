using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Device list information.
/// </summary>
public record DeviceListResult
{
    /// <summary>
    /// Account name.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Total device count.
    /// </summary>
    [JsonPropertyName("deviceCount")]
    public required int DeviceCount { get; init; }

    /// <summary>
    /// List of devices with id in IMEI.
    /// </summary>
    [JsonPropertyName("deviceList")]
    [MaxLength(1000)]
    public required IReadOnlyList<V3Device> DeviceList { get; init; }
}
