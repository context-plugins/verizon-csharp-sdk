using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Allowed start and end time windows.
/// </summary>
public record V2TimeWindow
{
    /// <summary>
    /// Start hour in range [0..23], current hour &gt;= startTime.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required int StartTime { get; init; }

    /// <summary>
    /// End hour in range [1..24], current hour &lt; endTime.
    /// </summary>
    [JsonPropertyName("endTime")]
    public required int EndTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
