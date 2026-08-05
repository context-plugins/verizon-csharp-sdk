using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GetDeviceStatusesResponseforplanner
{
    /// <summary>
    /// The numeric name of the account, including leading zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    public string? RequestId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceStatusList")]
    public IReadOnlyList<DeviceStatusItemforplanner?>? DeviceStatusList { get; init; }
}
