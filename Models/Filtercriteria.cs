using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Filtercriteria
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterCriteria")]
    public IReadOnlyList<ReadySimServicePlan>? FilterCriteria { get; init; }
}
