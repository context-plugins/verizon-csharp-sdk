using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Firmware upgrade information.
/// </summary>
public record Campaign
{
    /// <summary>
    /// Upgrade identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Account identifier.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Campaign name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("campaignName")]
    public string? CampaignName { get; init; }

    /// <summary>
    /// Name of firmware.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firmwareName")]
    public string? FirmwareName { get; init; }

    /// <summary>
    /// Old firmware version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firmwareFrom")]
    public string? FirmwareFrom { get; init; }

    /// <summary>
    /// New firmware version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firmwareTo")]
    public string? FirmwareTo { get; init; }

    /// <summary>
    /// The protocol of the firmware distribution. Default: LWM2M.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; init; } = "LWM2M";

    /// <summary>
    /// Applicable make.
    /// </summary>
    [JsonPropertyName("make")]
    public required string Make { get; init; }

    /// <summary>
    /// Applicable model.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

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
    /// Firmware upgrade status.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    /// <summary>
    /// Any device included in the device list which does not have a license will automatically be assigned a FOTA license, assuming there are enough FOTA licenses available, when set to true.
    /// </summary>
    [JsonPropertyName("autoAssignLicenseFlag")]
    public required bool AutoAssignLicenseFlag { get; init; }

    /// <summary>
    /// Beyond the devices included on the device list, any other device(s) which matches the eligibility criteria (same make, model, current firmware, protocol, billing account) will automatically be added to the campaign list during the life of the campaign when set to true.
    /// </summary>
    [JsonPropertyName("autoAddDevicesFlag")]
    public required bool AutoAddDevicesFlag { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
