using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record SetFallbackAttributeRequest
{
    [JsonPropertyName("devices")]
    [MaxLength(100)]
    public required IReadOnlyList<DeviceList> Devices { get; init; }

    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierName")]
    public string? CarrierName { get; init; }
}
