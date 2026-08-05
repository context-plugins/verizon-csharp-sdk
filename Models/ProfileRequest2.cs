using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ProfileRequest2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devices")]
    [MaxLength(100)]
    public IReadOnlyList<DeviceList2>? Devices { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierName")]
    public string? CarrierName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reasonCode")]
    public string? ReasonCode { get; init; }

    [JsonPropertyName("etfWaiver")]
    public bool? EtfWaiver { get; init; } = true;

    [JsonPropertyName("checkFallbackProfile")]
    public bool? CheckFallbackProfile { get; init; } = false;
}
