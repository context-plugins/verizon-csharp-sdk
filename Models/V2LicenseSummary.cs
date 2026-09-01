using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Summary of license assignment.
/// </summary>
public record V2LicenseSummary
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Total FOTA license count.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalLicense")]
    public int? TotalLicense { get; init; }

    /// <summary>
    /// Assigned FOTA license count.
    /// </summary>
    [JsonPropertyName("assignedLicenses")]
    public required int AssignedLicenses { get; init; }

    /// <summary>
    /// True if there are more devices to retrieve.
    /// </summary>
    [JsonPropertyName("hasMoreData")]
    public required bool HasMoreData { get; init; }

    /// <summary>
    /// Last seen device identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastSeenDeviceId")]
    public string? LastSeenDeviceId { get; init; }

    /// <summary>
    /// Maximum page size.
    /// </summary>
    [JsonPropertyName("maxPageSize")]
    public required int MaxPageSize { get; init; }

    /// <summary>
    /// Device IMEI list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceList")]
    public IReadOnlyList<V2LicenseDevice>? DeviceList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
