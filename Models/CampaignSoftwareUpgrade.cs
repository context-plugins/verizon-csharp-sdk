using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Software upgrade information.
/// </summary>
public record CampaignSoftwareUpgrade
{
    /// <summary>
    /// Campaign name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("campaignName")]
    public string? CampaignName { get; init; }

    /// <summary>
    /// Software name to upgrade to.
    /// </summary>
    [JsonPropertyName("softwareName")]
    public required string SoftwareName { get; init; }

    /// <summary>
    /// Old software name.
    /// </summary>
    [JsonPropertyName("softwareFrom")]
    public required string SoftwareFrom { get; init; }

    /// <summary>
    /// New software name.
    /// </summary>
    [JsonPropertyName("softwareTo")]
    public required string SoftwareTo { get; init; }

    /// <summary>
    /// OMA or HTTP.
    /// </summary>
    [JsonPropertyName("distributionType")]
    public required string DistributionType { get; init; }

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
    /// Specifies starting date client should download package. If null, client will download as soon as possible.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("downloadAfterDate")]
    public DateTimeOffset? DownloadAfterDate { get; init; }

    /// <summary>
    /// List of allowed download time windows.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("downloadTimeWindowList")]
    public IReadOnlyList<V2TimeWindow>? DownloadTimeWindowList { get; init; }

    /// <summary>
    /// Client will install package after date. If null, client will install as soon as possible.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installAfterDate")]
    public DateTimeOffset? InstallAfterDate { get; init; }

    /// <summary>
    /// List of allowed install time windows.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installTimeWindowList")]
    public IReadOnlyList<V2TimeWindow>? InstallTimeWindowList { get; init; }

    /// <summary>
    /// Device IMEI list.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<string> DeviceList { get; init; }
}
