using System.Text.Json.Serialization;
using Verizon.Core.Models;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
