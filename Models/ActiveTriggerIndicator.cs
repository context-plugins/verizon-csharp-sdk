using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Whether the trigger is active or not.
/// </summary>
public record ActiveTriggerIndicator
{
    /// <summary>
    /// Indicates if the trigger is active&lt;br /&gt;True - trigger is active&lt;br /&gt;False - trigger is not active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }
}
