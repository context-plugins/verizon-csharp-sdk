using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Cellphonenumber
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrier")]
    public string? Carrier { get; init; }
}
