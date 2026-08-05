using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// List of the field names and values to set.
/// </summary>
public record ConfigurationModel
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frequency")]
    public string? Frequency { get; init; }
}
