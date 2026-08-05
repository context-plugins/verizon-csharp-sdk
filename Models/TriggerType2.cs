using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Trigger details.
/// </summary>
public record TriggerType2
{
    /// <summary>
    /// The details of the UsageAnomaly trigger.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("anomalyattributes")]
    public UsageAnomalyAttributes? Anomalyattributes { get; init; }

    /// <summary>
    /// The notification details of the trigger.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notification")]
    public TriggerNotification? Notification { get; init; }
}
