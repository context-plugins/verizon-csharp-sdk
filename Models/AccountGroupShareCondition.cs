using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record AccountGroupShareCondition
{
    /// <summary>
    /// The action taken when trigger conditions are met
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public ConditionAction? Action { get; init; }
}
