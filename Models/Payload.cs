using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record Payload
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addsensor")]
    public ResourceOnBoardSensor? Addsensor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
