using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record RateplantypeObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratePlanGroupDescription")]
    public string? RatePlanGroupDescription { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratePlanType")]
    public string? RatePlanType { get; init; }

    /// <summary>
    /// An array of rateplan names
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratePlan")]
    public IReadOnlyList<Rateplantype2>? RatePlan { get; init; }
}
