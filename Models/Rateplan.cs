using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

public record Rateplan
{
    /// <summary>
    /// An array of rate plan group names
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratePlanGroup")]
    public IReadOnlyList<RatePlanGroup>? RatePlanGroup { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
