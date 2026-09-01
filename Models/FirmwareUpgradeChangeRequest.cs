using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// List of devices to add or remove.
/// </summary>
public record FirmwareUpgradeChangeRequest
{
    /// <summary>
    /// Possible values are <c>append</c> or <c>remove</c>
    /// </summary>
    [JsonPropertyName("type")]
    public required FirmwareTypeList Type { get; init; }

    /// <summary>
    /// The IMEIs of the devices.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<string> DeviceList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
