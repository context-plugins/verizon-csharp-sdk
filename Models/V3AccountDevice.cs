using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Device information.
/// </summary>
public record V3AccountDevice
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
    /// Device firmware version.
    /// </summary>
    [JsonPropertyName("firmware")]
    public required string Firmware { get; init; }

    /// <summary>
    /// Value=true if the device software can be upgraded over the air using the Software Management Services API.
    /// </summary>
    [JsonPropertyName("fotaEligible")]
    public required bool FotaEligible { get; init; }

    /// <summary>
    /// Device status.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    /// <summary>
    /// License assigned device.
    /// </summary>
    [JsonPropertyName("licenseAssigned")]
    public required bool LicenseAssigned { get; init; }

    /// <summary>
    /// Firmware protocol. Valid values include: LWM2M, OMADM, HTTP or NONE.
    /// </summary>
    [JsonPropertyName("protocol")]
    public required string Protocol { get; init; }

    /// <summary>
    /// List of sofware.
    /// </summary>
    [JsonPropertyName("softwareList")]
    public required IReadOnlyList<V3SoftwareInfo> SoftwareList { get; init; }

    /// <summary>
    /// List of files.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fileList")]
    public IReadOnlyList<V3SoftwareInfo>? FileList { get; init; }

    /// <summary>
    /// The date and time of when the device is created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; init; }

    /// <summary>
    /// The date and time of when the device firmware or software is updated.
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
}
