using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record AggregateUsage
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public GiodeviceId? DeviceId { get; init; }

    /// <summary>
    /// The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9]{3,32}$")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The start date of the time period queried as "$datetime"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startTime")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9]{3,32}$")]
    public string? StartTime { get; init; }

    /// <summary>
    /// The end date of the time period being queried as "$datetime"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endTime")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9]{3,32}$")]
    public string? EndTime { get; init; }
}
