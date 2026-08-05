using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A result containing a list of anomaly triggers.
/// </summary>
public record AnomalyTriggerResult
{
    /// <summary>
    /// Trigger value chunk details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggers")]
    public IReadOnlyList<TriggersListOptions>? Triggers { get; init; }
}
