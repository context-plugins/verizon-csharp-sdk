using System.Text.Json.Serialization;

namespace Verizon.Models;

public record AccountShareFilterCriteria
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterCriteria")]
    public AccountShareFilterCriteria1? FilterCriteria { get; init; }
}
