using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ExtendedAttribute
{
    /// <summary>
    /// The key indicates if the SMS message was to the device (MtSms) or from the device (MoSms)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9]{3,32}$")]
    public string? Key { get; init; }

    /// <summary>
    /// The number of SMS messages found
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9]{3,32}$")]
    public string? Value { get; init; }
}
