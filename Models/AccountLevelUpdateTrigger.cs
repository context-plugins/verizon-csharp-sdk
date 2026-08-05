using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record AccountLevelUpdateTrigger
{
    /// <summary>
    /// The system assigned UUID of the trigger
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; init; }

    /// <summary>
    /// The user defined name of the trigger
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerName")]
    public string? TriggerName { get; init; }

    /// <summary>
    /// The Enterprise Customer Profile Database ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ecpdId")]
    public string? EcpdId { get; init; }

    /// <summary>
    /// The type of trigger being created or modified
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerCategory")]
    public TriggerCategory? TriggerCategory { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataTrigger")]
    public DataTrigger1? DataTrigger { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notification")]
    public Notificationarray? Notification { get; init; }
}
