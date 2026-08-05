using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A list of deviceId objects to use when requesting information from multiple devices.
/// </summary>
public record AccountDeviceList
{
    /// <summary>
    /// All identifiers for the device.
    /// </summary>
    [JsonPropertyName("deviceIds")]
    public required IReadOnlyList<DeviceId> DeviceIds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9].[0-9].[0-9].[0-9]{3,32}$")]
    public string? IpAddress { get; init; }
}
