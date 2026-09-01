using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record AuthRestErrorResponseforplannerError
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fault")]
    public AuthSubRestErrorResponseforplanner? Fault { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
