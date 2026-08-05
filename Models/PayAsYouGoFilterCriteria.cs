using System.Text.Json.Serialization;

namespace Verizon.Models;

public record PayAsYouGoFilterCriteria
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterCriteria")]
    public PayAsYouGoFilterCriteria1? FilterCriteria { get; init; }
}
