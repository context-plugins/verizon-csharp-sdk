using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GiodeactivateDeviceProfileRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devices")]
    [MaxLength(100)]
    public IReadOnlyList<GiodeviceList>? Devices { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9\\-]{3,32}$")]
    public string? AccountName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlan")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9 ]{3,32}$")]
    public string? ServicePlan { get; init; }

    [JsonPropertyName("etfWaiver")]
    public bool? EtfWaiver { get; init; } = false;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reasonCode")]
    [StringLength(32, MinimumLength = 2)]
    [RegularExpression("^[0-9A-Z]{2,32}$")]
    public string? ReasonCode { get; init; }
}
