using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record UsageTriggerUpdateRequest
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
    /// The percent of subscribed usage required to activate the trigger, such as 90 or 100.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thresholdValue")]
    public string? ThresholdValue { get; init; }

    /// <summary>
    /// Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or parentheses, etc.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smsPhoneNumbers")]
    public string? SmsPhoneNumbers { get; init; }

    /// <summary>
    /// Comma-separated list of email addresses to send alerts to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emailAddresses")]
    public string? EmailAddresses { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
