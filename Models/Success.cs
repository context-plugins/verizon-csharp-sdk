using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Success
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
