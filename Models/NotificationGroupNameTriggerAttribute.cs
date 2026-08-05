using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Notification group name trigger attribute.
/// </summary>
public record NotificationGroupNameTriggerAttribute
{
    /// <summary>
    /// If present, the NotificationGroupName will be listed here.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }
}
