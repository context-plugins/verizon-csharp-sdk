using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GetDeviceStatusesRequestforplanner
{
    /// <summary>
    /// The numeric name of the account, including leading zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; init; }

    /// <summary>
    /// The unique ID of a request. This is a UUID value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    public string? RequestId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devices")]
    public IReadOnlyList<DeviceListforplanner?>? Devices { get; init; }
}
