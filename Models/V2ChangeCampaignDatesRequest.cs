using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// New dates and time windows.
/// </summary>
public record V2ChangeCampaignDatesRequest
{
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
    /// List of allowed download time windows. Removing of existing windows is not allowed.
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
    /// List of allowed install time windows. Removing of existing windows is not allowed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installTimeWindowList")]
    public IReadOnlyList<V2TimeWindow>? InstallTimeWindowList { get; init; }
}
