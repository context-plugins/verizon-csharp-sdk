using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Status of the report.
/// </summary>
public record LocationReportStatus
{
    /// <summary>
    /// The transaction ID of the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txid")]
    public string? Txid { get; init; }

    /// <summary>
    /// Status of the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public ReportStatus? Status { get; init; }
}
