using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Account device information.
/// </summary>
public record V2AccountDevice
{
    /// <summary>
    /// Device identifier.
    /// </summary>
    [JsonPropertyName("deviceId")]
    public required string DeviceId { get; init; }

    /// <summary>
    /// MDN.
    /// </summary>
    [JsonPropertyName("mdn")]
    public required string Mdn { get; init; }

    /// <summary>
    /// Device model.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Device make.
    /// </summary>
    [JsonPropertyName("make")]
    public required string Make { get; init; }

    /// <summary>
    /// Device FOTA capable.
    /// </summary>
    [JsonPropertyName("fotaEligible")]
    public required bool FotaEligible { get; init; }

    /// <summary>
    /// Device application FOTA capable.
    /// </summary>
    [JsonPropertyName("appFotaEligible")]
    public required bool AppFotaEligible { get; init; }

    /// <summary>
    /// License assigned device.
    /// </summary>
    [JsonPropertyName("licenseAssigned")]
    public required bool LicenseAssigned { get; init; }

    /// <summary>
    /// LWM2M, OMD-DM or HTTP.
    /// </summary>
    [JsonPropertyName("distributionType")]
    public required string DistributionType { get; init; }

    /// <summary>
    /// List of sofware.
    /// </summary>
    [JsonPropertyName("softwareList")]
    public required IReadOnlyList<V2SoftwareInfo> SoftwareList { get; init; }

    /// <summary>
    /// The date and time of when the device is created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; init; }

    /// <summary>
    /// The date and time of when the device firmware or software is upgraded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("upgradeTime")]
    public string? UpgradeTime { get; init; }

    /// <summary>
    /// The date and time of when the device is updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; init; }

    /// <summary>
    /// The date and time of when the device is refreshed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refreshTime")]
    public string? RefreshTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
