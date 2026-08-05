using System.Text.Json.Serialization;

namespace Verizon.Models;

public record FiltercriteriaObjectCall
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterCriteria")]
    public FilterCriteria1? FilterCriteria { get; init; }
}
