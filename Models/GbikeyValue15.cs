using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GbikeyValue15
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public string? Value { get; init; }
}
