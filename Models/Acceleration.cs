using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Acceleration
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("x")]
    public string? X { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("y")]
    public string? Y { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("z")]
    public string? Z { get; init; }
}
