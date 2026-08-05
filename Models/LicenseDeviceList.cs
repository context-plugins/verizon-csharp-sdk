using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// List of all devices.
/// </summary>
public record LicenseDeviceList
{
    /// <summary>
    /// For 4G devices, IMEI (decimal, up to 15 digits).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceIds")]
    [MaxLength(100)]
    public IReadOnlyList<LicenseDeviceId>? DeviceIds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9].[0-9].[0-9].[0-9]{3,32}$")]
    public string? IpAddress { get; init; }
}
