using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Details of the firmware upgrade request.
/// </summary>
public record FirmwareUpgradeRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// The name of the firmware image that will be used for the upgrade, from a GET /firmware response.
    /// </summary>
    [JsonPropertyName("firmwareName")]
    public required string FirmwareName { get; init; }

    /// <summary>
    /// The name of the firmware version that will be on the devices after a successful upgrade.
    /// </summary>
    [JsonPropertyName("firmwareTo")]
    public required string FirmwareTo { get; init; }

    /// <summary>
    /// The date that the upgrade begins.
    /// </summary>
    [JsonPropertyName("startDate")]
    public required DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// The date that the upgrade ends.
    /// </summary>
    [JsonPropertyName("endDate")]
    public required DateTimeOffset EndDate { get; init; }

    /// <summary>
    /// The IMEIs of the devices.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<string> DeviceList { get; init; }
}
