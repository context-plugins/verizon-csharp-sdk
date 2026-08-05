using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

public record Notificationarray
{
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
}
