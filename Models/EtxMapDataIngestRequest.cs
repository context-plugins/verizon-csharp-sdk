using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// JSON representation of a J2735/ETSI MapData message for ingestion. The value field must contain a valid MAP message body conforming to the SAE J2735 or ETSI TS 103 301 standard.
/// </summary>
public record EtxMapDataIngestRequest
{
    /// <summary>
    /// SAE J2735 DSRCmsgID for the MAP message type.
    /// </summary>
    [JsonPropertyName("messageId")]
    [Minimum(0)]
    [Maximum(32767)]
    public required int MessageId { get; init; }

    /// <summary>
    /// The decoded MAP message body containing intersection and lane data.
    /// </summary>
    [JsonPropertyName("value")]
    public required object Value { get; init; }

    /// <summary>
    /// Issue revision number of the MAP message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("msgIssueRevision")]
    [Minimum(0)]
    [Maximum(255)]
    public int? MsgIssueRevision { get; init; }
}
