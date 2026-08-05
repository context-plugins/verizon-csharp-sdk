using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

public record Triggervalues
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerName")]
    public string? TriggerName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organizationName")]
    public string? OrganizationName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerCategory")]
    public string? TriggerCategory { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerAttributes")]
    public IReadOnlyList<KeysChunk>? TriggerAttributes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifiedAt")]
    public DateTimeOffset? ModifiedAt { get; init; }
}
