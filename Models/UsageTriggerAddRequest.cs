using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record UsageTriggerAddRequest
{
    /// <summary>
    /// Usage trigger name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerName")]
    public string? TriggerName { get; init; }

    /// <summary>
    /// Account name
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Service name
    /// </summary>
    [JsonPropertyName("serviceName")]
    public ServiceName ServiceName { get; init; } = ServiceName.Location;

    /// <summary>
    /// The percent of subscribed usage required to activate the trigger, such as 90 or 100.
    /// </summary>
    [JsonPropertyName("thresholdValue")]
    public required string ThresholdValue { get; init; }

    /// <summary>
    /// Allow additional requests after thresholdValue is reached. (currently not functional)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowExcess")]
    public bool? AllowExcess { get; init; }

    /// <summary>
    /// Send SMS (text) alerts when the thresholdValue is reached.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sendSmsNotification")]
    public bool? SendSmsNotification { get; init; }

    /// <summary>
    /// Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or parentheses, etc.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smsPhoneNumbers")]
    public string? SmsPhoneNumbers { get; init; }

    /// <summary>
    /// Send email alerts when the thresholdValue is reached.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sendEmailNotification")]
    public bool? SendEmailNotification { get; init; }

    /// <summary>
    /// Comma-separated list of email addresses to send alerts to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emailAddresses")]
    public string? EmailAddresses { get; init; }
}
