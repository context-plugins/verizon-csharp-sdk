using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Cause code wrapper for traffic condition events.
/// </summary>
public record TrafficConditionCauseCode
{
    /// <summary>
    /// The value shall be set to:
    /// - 0 <c>unavailable</c>                  - in case further detailed information on the traffic condition is unavailable,
    /// - 1 <c>increasedVolumeOfTraffic</c>     - in case the type of traffic condition is increased traffic volume,
    /// - 2 <c>trafficJamSlowlyIncreasing</c>   - in case the type of traffic condition is a traffic jam which volume is increasing slowly,
    /// - 3 <c>trafficJamIncreasing</c>         - in case the type of traffic condition is a traffic jam which volume is increasing,
    /// - 4 <c>trafficJamStronglyIncreasing</c> - in case the type of traffic condition is a traffic jam which volume is strongly increasing,
    /// - 5 <c>trafficJam</c>         `         - in case the type of traffic condition is a traffic jam and no further detailed information about its volume is available,
    /// - 6 <c>trafficJamSlightlyDecreasing</c> - in case the type of traffic condition is a traffic jam which volume is decreasing slowly,
    /// - 7 <c>trafficJamDecreasing</c>         - in case the type of traffic condition is a traffic jam which volume is decreasing,
    /// - 8 <c>trafficJamStronglyDecreasing</c> - in case the type of traffic condition is a traffic jam which volume is decreasing rapidly,
    /// - 9 <c>trafficJamStable</c>             - in case the traffic condition is a traffic jam with stable volume,
    /// - 10-255: reserved for future usage.
    /// </summary>
    [JsonPropertyName("trafficCondition1")]
    [Minimum(0)]
    [Maximum(255)]
    public required int TrafficCondition1 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
