using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Location information for up to 1,000 devices.
/// </summary>
public record LocationReport
{
    /// <summary>
    /// Device location information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devLocationList")]
    public IReadOnlyList<Location>? DevLocationList { get; init; }

    /// <summary>
    /// True if there are more device locations to retrieve.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasMoreData")]
    public bool? HasMoreData { get; init; }

    /// <summary>
    /// The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices to be returned (hasMoreData=true), set startIndex=1000 for the second request, 2000 for the third request, etc.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startIndex")]
    public string? StartIndex { get; init; }

    /// <summary>
    /// The total number of devices in the original request and in the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalCount")]
    public int? TotalCount { get; init; }

    /// <summary>
    /// The transaction ID of the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txid")]
    public string? Txid { get; init; }
}
