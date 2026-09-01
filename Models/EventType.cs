using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

/// <summary>
/// The type of event including direct and sub cause.
/// </summary>
public record EventType
{
    /// <summary>
    /// The main cause of a detected event. Each entry is of a different type and represents the sub cause code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ccAndScc")]
    public CauseCodeChoice? CcAndScc { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
