using System.Text.Json.Serialization;

namespace Verizon.Models;

public record AccountLevelFilter
{
    /// <summary>
    /// Determines whether or not to aggregate usage of multiple accounts together, or separate by account. If this is null or not present, then the trigger will be for an individual line.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("separateOrCombined")]
    public string? SeparateOrCombined { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountNames")]
    public Accountnames? AccountNames { get; init; }
}
