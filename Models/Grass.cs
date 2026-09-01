using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Indicates the surface of the roadway is grass.
/// </summary>
public record Grass
{
    /// <summary>
    /// Indicates the surface of the roadway is grass with low speed limit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type9? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
