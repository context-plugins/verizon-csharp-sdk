using System.Text.Json.Serialization;

namespace Verizon.Models;

public record AccountGroupShareFilterCriteria
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterCriteria")]
    public AccountGroupShareFilter? FilterCriteria { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("condition")]
    public AccountGroupShareCondition? Condition { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public AccountGroupShareAction? Action { get; init; }
}
