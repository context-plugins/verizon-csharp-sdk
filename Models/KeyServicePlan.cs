using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record KeyServicePlan
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
