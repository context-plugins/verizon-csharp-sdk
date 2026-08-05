using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The notification details of the trigger.
/// </summary>
public record TriggerNotification
{
    /// <summary>
    /// The type of notification, i.e. 'DailySummary'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; init; }

    /// <summary>
    /// Whether or not the notification should be sent via callback.&lt;br /&gt;true&lt;br /&gt;false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callback")]
    public bool? Callback { get; init; }

    /// <summary>
    /// Whether or not the notification should be sent via e-mail.&lt;br /&gt;true&lt;br /&gt;false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emailNotification")]
    public bool? EmailNotification { get; init; }

    /// <summary>
    /// Name for the notification group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notificationGroupName")]
    public string? NotificationGroupName { get; init; }

    /// <summary>
    /// Frequency factor for notification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notificationFrequencyFactor")]
    public int? NotificationFrequencyFactor { get; init; }

    /// <summary>
    /// Frequency interval for notification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notificationFrequencyInterval")]
    public string? NotificationFrequencyInterval { get; init; }

    /// <summary>
    /// E-mail address(es) where the notification should be delivered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("externalEmailRecipients")]
    public string? ExternalEmailRecipients { get; init; }

    /// <summary>
    /// SMS notification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smsNotification")]
    public bool? SmsNotification { get; init; }

    /// <summary>
    /// List of SMS numbers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smsNumbers")]
    [MaxLength(10)]
    public IReadOnlyList<Smsnumber>? SmsNumbers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reminder")]
    public bool? Reminder { get; init; }

    /// <summary>
    /// Severity level associated with the notification. Examples would be:&lt;br /&gt;Major&lt;br /&gt;Minor&lt;br /&gt;Critical&lt;br /&gt;NotApplicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("severity")]
    public string? Severity { get; init; }
}
