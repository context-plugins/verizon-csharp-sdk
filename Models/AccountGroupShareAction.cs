using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record AccountGroupShareAction
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notify")]
    public Notify? Notify { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
