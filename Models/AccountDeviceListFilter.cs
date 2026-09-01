using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Filter for a list of devices.
/// </summary>
public record AccountDeviceListFilter
{
    /// <summary>
    /// Specify the kind of the device identifier, the type of match, and the string that you want to match.
    /// </summary>
    [JsonPropertyName("deviceIdentifierFilters")]
    public required IReadOnlyList<DeviceIdSearch> DeviceIdentifierFilters { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
