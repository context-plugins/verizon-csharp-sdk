using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Indicates the surface of the roadway is portland cement.
/// </summary>
public record PortlandCement
{
    /// <summary>
    /// Indicates the type of portland cement.
    /// </summary>
    [JsonPropertyName("type")]
    public Type6? Type { get; init; } = Type6.Traveled;
}
