using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Models.AnyOf;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record AccountLevelUpdateTriggerRequest
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callback")]
    public bool? Callback { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emailNotification")]
    public bool? EmailNotification { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notificationGroupName")]
    public string? NotificationGroupName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notificationFrequencyFactor")]
    public int? NotificationFrequencyFactor { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notificationFrequencyInterval")]
    public string? NotificationFrequencyInterval { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("externalEmailRecipients")]
    public string? ExternalEmailRecipients { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smsNotification")]
    public bool? SmsNotification { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smsNumbers")]
    public IReadOnlyList<SmsNumberModel>? SmsNumbers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reminder")]
    public bool? Reminder { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("severity")]
    public string? Severity { get; init; }

    /// <summary>
    /// A flag to indicate of the trigger is active, true, or not, false
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public Active? Active { get; init; }
}
