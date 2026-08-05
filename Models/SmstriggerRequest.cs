using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

public record SmstriggerRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("comparator")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9]{3,32}$")]
    public string? Comparator { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smsType")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9]{3,32}$")]
    public string? SmsType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threshold")]
    [Minimum(0)]
    [Maximum(100)]
    public int? Threshold { get; init; }
}
