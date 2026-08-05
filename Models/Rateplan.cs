using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Rateplan
{
    /// <summary>
    /// An array of rate plan group names
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratePlanGroup")]
    public IReadOnlyList<RatePlanGroup>? RatePlanGroup { get; init; }
}
