using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Trigger attribute for when data percentage is over 90% used.
/// </summary>
public record DataPercentage90TriggerAttribute
{
    /// <summary>
    /// Key data percentage 90.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    /// <summary>
    /// DataPercentage90&lt;br /&gt;True - Trigger on Data percentage is over 90% used&lt;br /&gt;False - Do not trigger when over 90% used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public bool? Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
