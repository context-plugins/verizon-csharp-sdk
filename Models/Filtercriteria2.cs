using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Filtercriteria2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterCriteria")]
    public IReadOnlyList<object>? FilterCriteria { get; init; }
}
