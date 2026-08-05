using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Device Firmware Information.
/// </summary>
public record DeviceFirmwareList
{
    /// <summary>
    /// Account name.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// List of device &amp; firmware.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceFirmwarVersionList")]
    public IReadOnlyList<DeviceFirmwareVersion>? DeviceFirmwarVersionList { get; init; }
}
