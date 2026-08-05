using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record PromoAlert
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterCriteria")]
    public IReadOnlyList<ReadySimServicePlan>? FilterCriteria { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("condition")]
    public IReadOnlyList<Keyschunk2>? Condition { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enablePromoExp")]
    public bool? EnablePromoExp { get; init; }
}
