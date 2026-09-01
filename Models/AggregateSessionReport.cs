using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Session and usage details for up to 10 devices.
/// </summary>
public record AggregateSessionReport
{
    /// <summary>
    /// A unique string (UUID) that associates the request with the location report information that is sent in asynchronous callback message.ThingSpace will send a separate callback message for each device that was in the request. All of the callback messages will have a txid.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txid")]
    public string? Txid { get; init; }

    /// <summary>
    /// Contains usage per device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usage")]
    [UniqueItems]
    public IReadOnlyList<AggregateUsageItem>? Usage { get; init; }

    /// <summary>
    /// An object containing any errors reported by the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    [UniqueItems]
    public IReadOnlyList<AggregateUsageError>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
