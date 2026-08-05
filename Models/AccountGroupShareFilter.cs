using System.Text.Json.Serialization;

namespace Verizon.Models;

public record AccountGroupShareFilter
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratePlanGroupId")]
    public int? RatePlanGroupId { get; init; }
}
