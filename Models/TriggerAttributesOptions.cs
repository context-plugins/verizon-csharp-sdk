using System.Text.Json.Serialization;

namespace Verizon.Models;

public record TriggerAttributesOptions
{
    /// <summary>
    /// If present, the NotificationGroupName will be listed here.
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
}
