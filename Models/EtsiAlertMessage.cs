using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Decentralized Environmental Notification Message (DENM) message and its mandatory fields. It is used in order to alert road users of a detected event using ITS communication technologies.
/// </summary>
public record EtsiAlertMessage
{
    /// <summary>
    /// DENM (Decentralized Environmental Notification Message) payload as defined in ETSI.
    /// </summary>
    [JsonPropertyName("etsiAlert")]
    public required EtsiAlertPayload EtsiAlert { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
