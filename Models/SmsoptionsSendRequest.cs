using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record SmsoptionsSendRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlan")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9 ]{3,32}$")]
    public string? ServicePlan { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smsMessage")]
    [StringLength(64, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9 ]{3,64}$")]
    public string? SmsMessage { get; init; }
}
