using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Traveler Information Message (TIM) message and its mandatory fields. The traveler information message is used to send various types of information (advisory and road sign types) to equipped devices.
/// </summary>
public record SaeInfoMessage
{
    /// <summary>
    /// Traveler Information Message (TIM) payload as defined in SAE J2735.
    /// </summary>
    [JsonPropertyName("saeInfo")]
    public required SaeInfoPayload SaeInfo { get; init; }
}
