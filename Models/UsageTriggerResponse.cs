using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record UsageTriggerResponse
{
    /// <summary>
    /// Unique usage triggerId
    /// </summary>
    [JsonPropertyName("triggerId")]
    public required string TriggerId { get; init; }

    /// <summary>
    /// Usage trigger name
    /// </summary>
    [JsonPropertyName("triggerName")]
    public required string TriggerName { get; init; }

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
    /// Percent of subscription at which trigger will send an alert
    /// </summary>
    [JsonPropertyName("thresholdValue")]
    public required string ThresholdValue { get; init; }

    /// <summary>
    /// allowExcess determines whether to restrict usage after exceeds limits
    /// </summary>
    [JsonPropertyName("allowExcess")]
    public required bool AllowExcess { get; init; }

    /// <summary>
    /// Send SMS (text) alerts when the thresholdValue is reached.
    /// </summary>
    [JsonPropertyName("sendSmsNotification")]
    public required bool SendSmsNotification { get; init; }

    /// <summary>
    /// comma seperated value of list of Phone numbers for SMS notifications
    /// </summary>
    [JsonPropertyName("smsPhoneNumbers")]
    public required string SmsPhoneNumbers { get; init; }

    /// <summary>
    /// Send email alerts when the thresholdValue is reached.
    /// </summary>
    [JsonPropertyName("sendEmailNotification")]
    public required bool SendEmailNotification { get; init; }

    /// <summary>
    /// comma seperated value of list of Email addresses for Email notifications
    /// </summary>
    [JsonPropertyName("emailAddresses")]
    public required string EmailAddresses { get; init; }

    /// <summary>
    /// UTC Date when the usage trigger was created
    /// </summary>
    [JsonPropertyName("createDate")]
    public required string CreateDate { get; init; }

    /// <summary>
    /// UTC Date when the usage trigger was last updated
    /// </summary>
    [JsonPropertyName("updateDate")]
    public required string UpdateDate { get; init; }
}
