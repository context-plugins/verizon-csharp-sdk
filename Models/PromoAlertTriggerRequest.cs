using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

public record PromoAlertTriggerRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataPercentage50")]
    public bool? DataPercentage50 { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataPercentage75")]
    public bool? DataPercentage75 { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataPercentage90")]
    public bool? DataPercentage90 { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("noOfDaysB4PromoExp")]
    [Minimum(0)]
    [Maximum(180)]
    public int? NoOfDaysB4PromoExp { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smsPercentage50")]
    public bool? SmsPercentage50 { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smsPercentage75")]
    public bool? SmsPercentage75 { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smsPercentage90")]
    public bool? SmsPercentage90 { get; init; }
}
