using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Trigger details.
/// </summary>
public record TriggerType3
{
    /// <summary>
    /// Trigger ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; init; }

    /// <summary>
    /// Trigger name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerName")]
    public string? TriggerName { get; init; }

    /// <summary>
    /// This is the value to use in the request body to detect anomalous behaivior. The values in this table will only be relevant when this parameter is set to this value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerCategory")]
    public string? TriggerCategory { get; init; }

    /// <summary>
    /// Account name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    [StringLength(32, MinimumLength = 3)]
    public string? AccountName { get; init; }

    /// <summary>
    /// The details of the UsageAnomaly trigger.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("anomalyTriggerRequest")]
    public AnomalyTriggerRequest? AnomalyTriggerRequest { get; init; }

    /// <summary>
    /// The notification details of the trigger.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notification")]
    public TriggerNotification? Notification { get; init; }
}
