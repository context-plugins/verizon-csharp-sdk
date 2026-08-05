using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A list of device IDs
/// </summary>
public record HplAccountDeviceList
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceIds")]
    public IReadOnlyList<HplDeviceId>? DeviceIds { get; init; }
}
