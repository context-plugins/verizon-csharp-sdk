using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Array of upgrade objects with the specified status.
/// </summary>
public record FirmwareUpgrade
{
    /// <summary>
    /// The unique identifier for this upgrade.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The name of the firmware image that will be used for the upgrade.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firmwareName")]
    public string? FirmwareName { get; init; }

    /// <summary>
    /// The name of the firmware version that will be on the devices after a successful upgrade.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firmwareTo")]
    public string? FirmwareTo { get; init; }

    /// <summary>
    /// The intended start date for the upgrade.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startDate")]
    public string? StartDate { get; init; }

    /// <summary>
    /// The current status of the upgrade.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// A JSON object for each device that was included in the upgrade, showing the device IMEI, the status of the upgrade, and additional information about the status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceList")]
    public IReadOnlyList<FirmwareUpgradeDeviceListItem>? DeviceList { get; init; }
}
