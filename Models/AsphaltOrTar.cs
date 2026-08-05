using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Indicates the surface of the roadway is asphalt or tar.
/// </summary>
public record AsphaltOrTar
{
    /// <summary>
    /// Indicates the type of asphalt or tar.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type7? Type { get; init; }
}
