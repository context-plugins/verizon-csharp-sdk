using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DeviceListWithServiceAddress
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public IReadOnlyList<GbideviceId15>? DeviceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryPlaceofuse")]
    public GbiaddressAndcustomerinfo5? PrimaryPlaceofuse { get; init; }
}
