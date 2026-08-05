using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Cause code wrapper for roadworks events.
/// </summary>
public record RoadworksCauseCode
{
    /// <summary>
    /// The value shall be set to:
    /// - 0 <c>unavailable</c>                 - in case further detailed information on roadworks is unavailable,
    /// - 1 <c>majorRoadworks</c>              - in case a major roadworks is ongoing,
    /// - 2 <c>roadMarkingWork</c>             - in case a road marking work is ongoing,
    /// - 3 <c>slowMovingRoadMaintenance</c>   - in case slow moving road maintenance work is ongoing,
    /// - 4 <c>shortTermStationaryRoadworks</c>- in case a short term stationary roadwork is ongoing,
    /// - 5 <c>streetCleaning</c>              - in case a vehicle street cleaning work is ongoing,
    /// - 6 <c>winterService</c>               - in case winter service work is ongoing,
    /// - 7 <c>setupPhase</c>                  - in case the work zone is being setup,
    /// - 8 <c>remodellingPhase</c>            - in case the work zone is being changed,
    /// - 9 <c>dismantlingPhase</c>            - in case the work zone is being dismantled after finished work.
    /// - 10-255                          - are reserved for future usage.
    /// </summary>
    [JsonPropertyName("roadworks3")]
    [Minimum(0)]
    [Maximum(255)]
    public required int Roadworks3 { get; init; }
}
