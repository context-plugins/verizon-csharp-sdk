using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record EnablePromoExp1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enablePromoExp")]
    public bool? EnablePromoExp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
