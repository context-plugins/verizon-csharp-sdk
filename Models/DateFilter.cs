using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Filter out the dates.
/// </summary>
public record DateFilter
{
    /// <summary>
    /// Only include devices that were added after this date and time.
    /// </summary>
    [JsonPropertyName("earliest")]
    public required string Earliest { get; init; }

    /// <summary>
    /// Only include devices that were added before this date and time.
    /// </summary>
    [JsonPropertyName("latest")]
    public required string Latest { get; init; }
}
