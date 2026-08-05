using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Location coordinates.
/// </summary>
public record Locationscoord
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("coordinatesList")]
    public IReadOnlyList<Coordinates>? CoordinatesList { get; init; }
}
