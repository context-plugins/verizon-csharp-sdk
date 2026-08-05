using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Tscore
{
    /// <summary>
    /// the UUID of the profile
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profileid")]
    public string? Profileid { get; init; }

    /// <summary>
    /// the UUID of the profile version
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profileversionid")]
    public string? Profileversionid { get; init; }
}
