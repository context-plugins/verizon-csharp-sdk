using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record AccountGroupShareUpdateTriggerRequest
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
    [JsonPropertyName("dataTrigger")]
    public AccountGroupShareObject? DataTrigger { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notification")]
    public Notificationarray? Notification { get; init; }

    /// <summary>
    /// A flag to indicate of the trigger is active, true, or not, false
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public Active? Active { get; init; }
}
