using System.Text.Json.Serialization;

namespace Verizon.Models;

public record BulkUpdateSmartalert
{
    /// <summary>
    /// User defined name of the record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
