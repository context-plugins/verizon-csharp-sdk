using System.Text.Json.Serialization;

namespace Verizon.Models;

public record NoOfDaysB4PromoExp
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public int? Value { get; init; }
}
