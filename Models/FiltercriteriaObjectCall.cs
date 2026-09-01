using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record FiltercriteriaObjectCall
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterCriteria")]
    public FilterCriteria1? FilterCriteria { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
