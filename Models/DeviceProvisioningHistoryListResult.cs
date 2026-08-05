using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Response to return the provisioning history of a specified device during a specified time period.
/// </summary>
public record DeviceProvisioningHistoryListResult
{
    /// <summary>
    /// False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasMoreData")]
    public bool? HasMoreData { get; init; }

    /// <summary>
    /// The provisioning history of a specified device during a specified time period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("provisioningHistory")]
    public IReadOnlyList<ProvisioningHistory>? ProvisioningHistory { get; init; }
}
