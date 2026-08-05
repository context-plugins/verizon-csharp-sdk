using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Response for a request to list down account devices.
/// </summary>
public record AccountDeviceListResult
{
    /// <summary>
    /// Up to 10,000 devices that you want to move to a different account, specified by device identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devices")]
    public IReadOnlyList<ThingspaceDevice>? Devices { get; init; }

    /// <summary>
    /// False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasMoreData")]
    public bool? HasMoreData { get; init; }
}
