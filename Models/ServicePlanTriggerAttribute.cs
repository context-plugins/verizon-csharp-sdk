using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Key service plan trigger attribute.
/// </summary>
public record ServicePlanTriggerAttribute
{
    /// <summary>
    /// The ServicePlan name will be listed here.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }
}
