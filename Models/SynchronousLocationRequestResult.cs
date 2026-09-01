using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record SynchronousLocationRequestResult
{
    /// <summary>
    /// The transaction ID of the report.
    /// </summary>
    [JsonPropertyName("txid")]
    public required string Txid { get; init; }

    /// <summary>
    /// Status of the report.
    /// </summary>
    [JsonPropertyName("status")]
    public required ReportStatus Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
