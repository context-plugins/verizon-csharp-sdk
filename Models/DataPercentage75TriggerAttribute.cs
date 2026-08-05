using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Trigger attribute for when data percentage is over 75% used.
/// </summary>
public record DataPercentage75TriggerAttribute
{
    /// <summary>
    /// Key data percentage 75.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    /// <summary>
    /// DataPercentage75&lt;br /&gt;True - Trigger on Data percentage is over 75% used&lt;br /&gt;False - Do not trigger when over 75% used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public bool? Value { get; init; }
}
