using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Device location information.
/// </summary>
public record Location
{
    /// <summary>
    /// MDN.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("msid")]
    public string? Msid { get; init; }

    /// <summary>
    /// Position data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pd")]
    public PositionData? Pd { get; init; }

    /// <summary>
    /// Position error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public PositionError? Error { get; init; }
}
