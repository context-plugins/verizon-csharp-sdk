using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Devices to add or remove from existing software upgrade information.
/// </summary>
public record V3AddOrRemoveDeviceRequest
{
    /// <summary>
    /// Operation either 'append' or 'remove'
    /// </summary>
    [JsonPropertyName("Type")]
    public required string Type { get; init; }

    /// <summary>
    /// Device IMEI list.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<string> DeviceList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
