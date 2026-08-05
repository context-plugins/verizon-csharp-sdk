using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// List of licenses assigned.
/// </summary>
public record V1ListOfLicensesToRemoveResult
{
    /// <summary>
    /// The total number of devices on the cancellation candidate list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    public int? Count { get; init; }

    /// <summary>
    /// The IMEIs of the devices.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceList")]
    public IReadOnlyList<string>? DeviceList { get; init; }
}
