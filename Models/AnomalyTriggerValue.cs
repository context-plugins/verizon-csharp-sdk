using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Trigger details.
/// </summary>
public record AnomalyTriggerValue
{
    /// <summary>
    /// The system assigned name of the trigger being updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; init; }

    /// <summary>
    /// The user defined name of the trigger.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerName")]
    public string? TriggerName { get; init; }

    /// <summary>
    /// The user assigned name of the organization associated with the trigger.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organizationName")]
    public string? OrganizationName { get; init; }

    /// <summary>
    /// This is the value to use in the request body to detect anomalous behaivior. The values in this table will only be relevant when this parameter is set to this value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerCategory")]
    public string? TriggerCategory { get; init; }

    /// <summary>
    /// Additional details and keys for the trigger.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerAttributes")]
    public IReadOnlyList<TriggerAttributesOptions>? TriggerAttributes { get; init; }

    /// <summary>
    /// Timestamp for whe the trigger was created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// Timestamp for the most recent time the trigger was modified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifiedAt")]
    public string? ModifiedAt { get; init; }
}
