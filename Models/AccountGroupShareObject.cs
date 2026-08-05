using System.Text.Json.Serialization;

namespace Verizon.Models;

public record AccountGroupShareObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountGroupShare")]
    public AccountGroupShareIndividual1? AccountGroupShare { get; init; }
}
