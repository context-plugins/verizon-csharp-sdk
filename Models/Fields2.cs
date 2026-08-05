using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// List of fields affected by the event.
/// </summary>
public record Fields2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("temperature")]
    public string? Temperature { get; init; }
}
