using System.Text.Json.Serialization;

namespace Verizon.Models;

public record AccountGroupShareAction
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notify")]
    public Notify? Notify { get; init; }
}
