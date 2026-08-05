using System.Text.Json.Serialization;

namespace Verizon.Models;

public record BillingCycle
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("year")]
    public string? Year { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("month")]
    public string? Month { get; init; }
}
