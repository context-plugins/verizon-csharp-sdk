using System.Text.Json.Serialization;

namespace Verizon.Models;

public record AccountGroupShareIndividual1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountGroupShareIndividual")]
    public AccountGroupShareFilterCriteria? AccountGroupShareIndividual { get; init; }
}
