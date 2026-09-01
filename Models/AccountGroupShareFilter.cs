using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record AccountGroupShareFilter
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratePlanGroupId")]
    public int? RatePlanGroupId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
