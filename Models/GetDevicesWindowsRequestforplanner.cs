using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GetDevicesWindowsRequestforplanner
{
    /// <summary>
    /// The numeric name of the account, including leading zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; init; }

    /// <summary>
    /// what windows to filter for: All - all 24 windows in a day, Best - top 3 windows by RAN KPI, Worst - lowest 3 windows by RAN KPI
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public string? Filter { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devices")]
    public IReadOnlyList<DeviceListforplanner?>? Devices { get; init; }
}
