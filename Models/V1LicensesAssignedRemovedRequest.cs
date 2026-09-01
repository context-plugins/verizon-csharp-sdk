using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// IMEIs of the devices to assign licenses to.
/// </summary>
public record V1LicensesAssignedRemovedRequest
{
    /// <summary>
    /// The IMEIs of the devices.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<string> DeviceList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
