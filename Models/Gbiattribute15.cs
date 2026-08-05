using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Gbiattribute15
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }
}
