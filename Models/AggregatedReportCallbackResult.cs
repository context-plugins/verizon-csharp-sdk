using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Aggregated usage report (Asynchronous).
/// </summary>
public record AggregatedReportCallbackResult
{
    /// <summary>
    /// A unique string (UUID) that associates the request with the location report information that is sent in asynchronous callback message.ThingSpace will send a separate callback message for each device that was in the request. All of the callback messages will have a txid.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txid")]
    public string? Txid { get; init; }

    /// <summary>
    /// QUEUED or COMPLETED. Requests for IoT devices with cacheMode=0 (cached) have status=COMPLETED; all other requests are QUEUED.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public AggregatedReportCallbackStatus? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
