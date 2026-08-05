using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record SchedulesSoftwareUpgradeRequest
{
    /// <summary>
    /// The campaign name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("campaignName")]
    public string? CampaignName { get; init; }

    /// <summary>
    /// Software name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("softwareName")]
    public string? SoftwareName { get; init; }

    /// <summary>
    /// Old software name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("softwareFrom")]
    public string? SoftwareFrom { get; init; }

    /// <summary>
    /// New software name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("softwareTo")]
    public string? SoftwareTo { get; init; }

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
}
