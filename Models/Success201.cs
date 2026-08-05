using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Success201
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    public string? RequestId { get; init; }
}
