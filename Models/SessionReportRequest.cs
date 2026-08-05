using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request for obtaining a session report.
/// </summary>
public record SessionReportRequest
{
    /// <summary>
    /// The numeric ID of the account and must include leading zeroes. This value is indentical to <c>accountName</c>.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The International Mobile Equipment Identifier of the device.
    /// </summary>
    [JsonPropertyName("imei")]
    public required string Imei { get; init; }

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
    /// Optional filter — minimum session duration
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("durationLow")]
    public int? DurationLow { get; init; }

    /// <summary>
    /// Optional filter — maximum session duration
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("durationHigh")]
    public int? DurationHigh { get; init; }
}
