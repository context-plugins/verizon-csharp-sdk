using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Position data.
/// </summary>
public record PositionData
{
    /// <summary>
    /// Time location obtained.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time")]
    public string? Time { get; init; }

    /// <summary>
    /// UTC offset of time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("utcoffset")]
    public string? Utcoffset { get; init; }

    /// <summary>
    /// X coordinate of location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("x")]
    public string? X { get; init; }

    /// <summary>
    /// Y coordinate of location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("y")]
    public string? Y { get; init; }

    /// <summary>
    /// Radius of the location in meters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("radius")]
    public string? Radius { get; init; }

    /// <summary>
    /// Whether requested accurary is met or not.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qos")]
    public bool? Qos { get; init; }
}
