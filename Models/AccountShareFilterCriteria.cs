using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record AccountShareFilterCriteria
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterCriteria")]
    public AccountShareFilterCriteria1? FilterCriteria { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
