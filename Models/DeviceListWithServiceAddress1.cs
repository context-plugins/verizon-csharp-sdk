using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DeviceListWithServiceAddress1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public IReadOnlyList<DeviceId>? DeviceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryPlaceofuse")]
    public GbiprimaryPlaceofuse5? PrimaryPlaceofuse { get; init; }
}
