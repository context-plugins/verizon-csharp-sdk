using System;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The time period for which a request should retrieve data, beginning with the limitTime.startOn and proceeding with the limitTime.duration.
/// </summary>
public record HistorySearchLimitTime
{
    /// <summary>
    /// The starting date-time for this request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startOn")]
    public DateTimeOffset? StartOn { get; init; }

    /// <summary>
    /// Describes value and unit of time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration")]
    public NumericalData? Duration { get; init; }
}
