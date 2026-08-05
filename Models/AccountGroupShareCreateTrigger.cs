using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record AccountGroupShareCreateTrigger
{
    /// <summary>
    /// The user defined name of the trigger
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerName")]
    public string? TriggerName { get; init; }

    /// <summary>
    /// The numeric name of the account and must include leading zeroes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The type of trigger being created or modified
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerCategory")]
    public TriggerCategory? TriggerCategory { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pricePlanTrigger")]
    public AccountGroupShareObject? PricePlanTrigger { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notification")]
    public Notificationarray? Notification { get; init; }
}
