using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A list of IMEIs for devices to be synchronized between ThingSpace and the FOTA server.
/// </summary>
public record FirmwareImei
{
    /// <summary>
    /// Device IMEI list.
    /// </summary>
    [JsonPropertyName("deviceList")]
    [MaxLength(1000)]
    public required IReadOnlyList<string> DeviceList { get; init; }
}
