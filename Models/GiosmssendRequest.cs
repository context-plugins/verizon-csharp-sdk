using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GiosmssendRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customFields")]
    [MaxLength(5)]
    public IReadOnlyList<KvPair>? CustomFields { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataEncoding")]
    public string? DataEncoding { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupName")]
    public string? GroupName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlan")]
    public string? ServicePlan { get; init; }

    /// <summary>
    /// A period of time the message remains valid or an end date for the message. This value would be less than the 5 day default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceIds")]
    [MaxLength(100)]
    public IReadOnlyList<GiodeviceId>? DeviceIds { get; init; }

    [JsonPropertyName("smsMessage")]
    public required string SmsMessage { get; init; }
}
