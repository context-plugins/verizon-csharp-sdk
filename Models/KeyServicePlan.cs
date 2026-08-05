using System.Text.Json.Serialization;

namespace Verizon.Models;

public record KeyServicePlan
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }
}
