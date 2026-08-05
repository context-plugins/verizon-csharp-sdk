using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record CreateTriggerRequestOptions
{
    /// <summary>
    /// Trigger name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

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

    /// <summary>
    /// Indicates anomaly detection is active&lt;br /&gt;True - Anomaly detection is active.&lt;br /&gt;False - Anomaly detection is not active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }
}
