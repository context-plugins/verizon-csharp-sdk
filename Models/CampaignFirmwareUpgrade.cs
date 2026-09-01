using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Firmware upgrade for devices.
/// </summary>
public record CampaignFirmwareUpgrade
{
    /// <summary>
    /// Campaign name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("campaignName")]
    public string? CampaignName { get; init; }

    /// <summary>
    /// Firmware name to upgrade to.
    /// </summary>
    [JsonPropertyName("firmwareName")]
    public required string FirmwareName { get; init; }

    /// <summary>
    /// Old firmware version.
    /// </summary>
    [JsonPropertyName("firmwareFrom")]
    public required string FirmwareFrom { get; init; }

    /// <summary>
    /// New firmware version.
    /// </summary>
    [JsonPropertyName("firmwareTo")]
    public required string FirmwareTo { get; init; }

    /// <summary>
    /// Valid values include: LWM2M, OMA and HTTP.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; init; } = "LWM2M";

    /// <summary>
    /// Campaign start date.
    /// </summary>
    [JsonPropertyName("startDate")]
    public required DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// Campaign end date.
    /// </summary>
    [JsonPropertyName("endDate")]
    public required DateTimeOffset EndDate { get; init; }

    /// <summary>
    /// List of allowed campaign time windows.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("campaignTimeWindowList")]
    public IReadOnlyList<V3TimeWindow>? CampaignTimeWindowList { get; init; }

    /// <summary>
    /// Device IMEI list.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<string> DeviceList { get; init; }

    /// <summary>
    /// This flag, when set to true, will assign a FOTA license automatically if the device does not have one already.
    /// </summary>
    [JsonPropertyName("autoAssignLicenseFlag")]
    public required bool AutoAssignLicenseFlag { get; init; }

    /// <summary>
    /// this flag, when set to true, will automatically add a device of the same make and model to a campaign.
    /// </summary>
    [JsonPropertyName("autoAddDevicesFlag")]
    public required bool AutoAddDevicesFlag { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
