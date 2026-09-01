using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record UploadAndScheduleFileRequest
{
    /// <summary>
    /// The campaign name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("campaignName")]
    public string? CampaignName { get; init; }

    /// <summary>
    /// The name of the file you are upgrading to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fileName")]
    public string? FileName { get; init; }

    /// <summary>
    /// The version of the file you are upgrading to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fileVersion")]
    public string? FileVersion { get; init; }

    /// <summary>
    /// Valid values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distributionType")]
    public string? DistributionType { get; init; }

    /// <summary>
    /// Campaign start date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startDate")]
    public string? StartDate { get; init; }

    /// <summary>
    /// Campaign end date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endDate")]
    public string? EndDate { get; init; }

    /// <summary>
    /// Specifies the starting date the client should download the package. If null, client downloads as soon as possible.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("downloadAfterDate")]
    public string? DownloadAfterDate { get; init; }

    /// <summary>
    /// List of allowed download time windows.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("downloadTimeWindowList")]
    public IReadOnlyList<DownloadTimeWindow>? DownloadTimeWindowList { get; init; }

    /// <summary>
    /// The date after which you install the package. If null, install as soon as possible.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installAfterDate")]
    public string? InstallAfterDate { get; init; }

    /// <summary>
    /// List of allowed install time windows.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installTimeWindowList")]
    public IReadOnlyList<DownloadTimeWindow>? InstallTimeWindowList { get; init; }

    /// <summary>
    /// Device IMEI list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceList")]
    public IReadOnlyList<string>? DeviceList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
