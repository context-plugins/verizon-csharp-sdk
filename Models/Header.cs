using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// The header of the DENM PDU.
/// </summary>
public record Header
{
    /// <summary>
    /// The protocol version of the DENM.
    /// </summary>
    [JsonPropertyName("protocolVersion")]
    public required ProtocolVersion ProtocolVersion { get; init; }

    /// <summary>
    /// The type of ITIS message (typically 1 for DENM).
    /// </summary>
    [JsonPropertyName("messageId")]
    public required MessageId MessageId { get; init; }

    /// <summary>
    /// The station identifier of the ITS-S.
    /// </summary>
    [JsonPropertyName("stationId")]
    public required int StationId { get; init; }
}
