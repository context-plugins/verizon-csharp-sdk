using System.Text.Json.Serialization;

namespace Verizon.Models;

public record SuccessResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public bool? Success { get; init; }
}
