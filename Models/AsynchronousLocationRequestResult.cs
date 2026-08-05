using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record AsynchronousLocationRequestResult
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

    /// <summary>
    /// Estimated number of minutes required to complete the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("estimatedDuration")]
    public string? EstimatedDuration { get; init; }
}
