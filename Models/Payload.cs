using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Payload
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addsensor")]
    public ResourceOnBoardSensor? Addsensor { get; init; }
}
