using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// License assignment or removal confirmation.
/// </summary>
public record V2LicensesAssignedRemovedResult
{
    /// <summary>
    /// Account name.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Total license count.
    /// </summary>
    [JsonPropertyName("licTotalCount")]
    public required int LicTotalCount { get; init; }

    /// <summary>
    /// Assigned license count.
    /// </summary>
    [JsonPropertyName("licUsedCount")]
    public required int LicUsedCount { get; init; }

    /// <summary>
    /// List of devices with id in IMEI.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<V2DeviceStatus> DeviceList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
