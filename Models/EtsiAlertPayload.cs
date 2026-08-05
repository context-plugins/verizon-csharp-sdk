using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// DENM (Decentralized Environmental Notification Message) payload as defined in ETSI.
/// </summary>
public record EtsiAlertPayload
{
    /// <summary>
    /// The header of the DENM PDU.
    /// </summary>
    [JsonPropertyName("header")]
    public required Header Header { get; init; }

    /// <summary>
    /// The payload of the DENM PDU.
    /// </summary>
    [JsonPropertyName("denm")]
    public required DenmPayload Denm { get; init; }
}
