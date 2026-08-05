using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Indicates the surface of the roadway is ice.
/// </summary>
public record Ice
{
    /// <summary>
    /// Indicates the type of ice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type12? Type { get; init; }
}
