using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Upgrade information.
/// </summary>
public record UpgradeListQueryResult
{
    /// <summary>
    /// True if there are more devices to retrieve.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasMoreFlag")]
    public bool? HasMoreFlag { get; init; }

    /// <summary>
    /// If hasMoreData=true, the startIndex to use for the next request. 0 if hasMoreData=false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastSeenUpgradeId")]
    public int? LastSeenUpgradeId { get; init; }

    /// <summary>
    /// Array of upgrade objects with the specified status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportList")]
    public IReadOnlyList<FirmwareUpgrade?>? ReportList { get; init; }
}
