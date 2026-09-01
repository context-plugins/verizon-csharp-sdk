using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record PayAsYouGoFilterCriteria
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterCriteria")]
    public PayAsYouGoFilterCriteria1? FilterCriteria { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
