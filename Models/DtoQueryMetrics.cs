using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoQueryMetrics
{
    /// <summary>
    /// The number of days in a recent period to query
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days")]
    public int? Days { get; init; }
}
