using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Account license information.
/// </summary>
public record AccountLicenseInfo
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// Number of monthly licenses in an MRC subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalLicenses")]
    public int? TotalLicenses { get; init; }

    /// <summary>
    /// Number of licenses currently assigned to devices.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assignedLicenses")]
    public int? AssignedLicenses { get; init; }

    /// <summary>
    /// True if there are more devices to retrieve.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasMoreData")]
    public bool? HasMoreData { get; init; }

    /// <summary>
    /// If hasMoreData=true, the startIndex to use for the next request. 0 if hasMoreData=false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastSeenDeviceId")]
    public int? LastSeenDeviceId { get; init; }

    /// <summary>
    /// The list of devices that have licenses assigned, including the date and time of when each license was assigned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceList")]
    public IReadOnlyList<AccountLicenseDeviceListItem>? DeviceList { get; init; }
}
