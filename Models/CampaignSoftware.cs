using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Software upgrade information.
/// </summary>
public record CampaignSoftware
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
    /// Software name.
    /// </summary>
    [JsonPropertyName("softwareName")]
    public required string SoftwareName { get; init; }

    /// <summary>
    /// LWM2M, OMD-DM or HTTP.
    /// </summary>
    [JsonPropertyName("distributionType")]
    public required string DistributionType { get; init; }

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
    /// Software upgrade status.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }
}
