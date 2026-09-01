using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Request for getting an aggregated session report.
/// </summary>
public record AggregateSessionReportRequest
{
    /// <summary>
    /// The numeric ID of the account and must include leading zeroes. This value is indentical to <c>accountName</c>.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// Start date of session to include. If not specified  information will be shown from the earliest available (180 days). Can be either date in ISO 8601 format or predefined constants.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startDate")]
    public string? StartDate { get; init; }

    /// <summary>
    /// End date of session to include. If not specified  information will be shown to the latest available. Can be either date in ISO 8601 format or predefined constants.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endDate")]
    public string? EndDate { get; init; }

    /// <summary>
    /// Devices for which return usage info. Could be 0, 1 or more. In case of 0 will return all devices belonging to customer (except of filtered by other parameters).
    /// </summary>
    [JsonPropertyName("imei")]
    public required IReadOnlyList<string> Imei { get; init; }

    /// <summary>
    /// Optional filter — only include devices matching this device group name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceGroup")]
    public string? DeviceGroup { get; init; }

    /// <summary>
    /// Optional filter — only include devices matching this carrier rate plan code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataPlan")]
    public string? DataPlan { get; init; }

    /// <summary>
    /// Optional filter — when "true", returns only devices with no sessions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("noSessionFlag")]
    public bool? NoSessionFlag { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
