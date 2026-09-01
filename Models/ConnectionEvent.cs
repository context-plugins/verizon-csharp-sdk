using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Network connection events for a device during a specified time period.
/// </summary>
public record ConnectionEvent
{
    /// <summary>
    /// The attributes that describe the connection event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("connectionEventAttributes")]
    public IReadOnlyList<CustomFields>? ConnectionEventAttributes { get; init; }

    /// <summary>
    /// Currently not used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extendedAttributes")]
    public IReadOnlyList<CustomFields>? ExtendedAttributes { get; init; }

    /// <summary>
    /// The date and time when the connection event occured.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("occurredAt")]
    public string? OccurredAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
