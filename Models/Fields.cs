using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// List of fields affected by the event.
/// </summary>
public record Fields
{
    /// <summary>
    /// List of the field names and values to set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("configuration")]
    public ConfigurationModel? Configuration { get; init; }
}
