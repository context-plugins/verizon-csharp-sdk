using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Trigger attribute for when data percentage is over 50% used.
/// </summary>
public record DataPercentage50TriggerAttribute
{
    /// <summary>
    /// Key data percentage 50.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    /// <summary>
    /// DataPercentage50&lt;br /&gt;True - Trigger on Data percentage is over 50% used&lt;br /&gt;False - Do not trigger when over 50% used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public bool? Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
