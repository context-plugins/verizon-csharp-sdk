using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record RetrieveMonitorsRequest
{
    /// <summary>
    /// The name of a billing account.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// The devices for which you want to restore service, specified by device identifier.
    /// </summary>
    [JsonPropertyName("devices")]
    public required IReadOnlyList<AccountDeviceList> Devices { get; init; }

    /// <summary>
    /// The name of a billing account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monitorType")]
    public string? MonitorType { get; init; }
}
