using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DeactivateDeviceProfileRequest
{
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    [JsonPropertyName("reasonCode")]
    public required string ReasonCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devices")]
    [MaxLength(100)]
    public IReadOnlyList<DeactivateDeviceList>? Devices { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierName")]
    public string? CarrierName { get; init; }

    [JsonPropertyName("etfWaiver")]
    public bool? EtfWaiver { get; init; } = true;

    [JsonPropertyName("checkFallbackProfile")]
    public bool? CheckFallbackProfile { get; init; } = false;
}
