using System.Text.Json.Serialization;

namespace Verizon.Models;

public record AuthRestErrorResponseforplannerError
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fault")]
    public AuthSubRestErrorResponseforplanner? Fault { get; init; }
}
