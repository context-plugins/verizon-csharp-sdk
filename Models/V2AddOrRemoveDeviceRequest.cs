using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Add or remove device to existing software upgrade information.
/// </summary>
public record V2AddOrRemoveDeviceRequest
{
    /// <summary>
    /// Operation either 'append' or 'remove'.
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
