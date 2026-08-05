using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Each service includes custom states.
/// </summary>
public record State
{
    /// <summary>
    /// The name of the state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The workflow sequence number of this state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("workflowSequenceNumber")]
    public double? WorkflowSequenceNumber { get; init; }

    /// <summary>
    /// The service plans that can be used to charge for services for devices in this state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlans")]
    public IReadOnlyList<string>? ServicePlans { get; init; }
}
