using System.Text.Json.Serialization;
using Verizon.Models.AnyOf;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record AccountLevelObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterCriteria")]
    public AccountLevelFilter? FilterCriteria { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("condition")]
    public AccountLevelObjectcondition? Condition { get; init; }

    /// <summary>
    /// The action taken when trigger conditions are met
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public AccountLevelAction? Action { get; init; }
}
