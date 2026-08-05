using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Streaming RF parameter that you want to observe.
/// </summary>
public record ObservationRequestAttribute
{
    /// <summary>
    /// Attribute identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public AttributeIdentifier? Name { get; init; }
}
