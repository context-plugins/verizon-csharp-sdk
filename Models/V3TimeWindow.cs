using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Time window.
/// </summary>
public record V3TimeWindow
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
}
