using System.Text.Json.Serialization;

namespace Verizon.Models;

public record KeyDataPercentage50
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public bool? Value { get; init; }
}
