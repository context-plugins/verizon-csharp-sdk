using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Cause code wrapper for emergency vehicle approaching events.
/// </summary>
public record EmergencyVehicleApproachingCauseCode
{
    /// <summary>
    /// The value shall be set to:
    /// - 0 <c>unavailable</c>                   - in case further detailed information on the emergency vehicle approaching event is unavailable,
    /// - 1 <c>emergencyVehicleApproaching</c>   - in case an operating emergency vehicle is approaching,
    /// - 2 <c>prioritizedVehicleApproaching</c> - in case a prioritized vehicle is approaching,
    /// - 3-255                             - reserved for future usage.
    /// </summary>
    [JsonPropertyName("emergencyVehicleApproaching95")]
    [Minimum(0)]
    [Maximum(255)]
    public required int EmergencyVehicleApproaching95 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
