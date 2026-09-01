using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record AccountGroupShareIndividual1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountGroupShareIndividual")]
    public AccountGroupShareFilterCriteria? AccountGroupShareIndividual { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
