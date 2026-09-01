using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Cause code wrapper for impassability events.
/// </summary>
public record ImpassabilityCauseCode
{
    /// <summary>
    /// The value shall be set to:
    /// - 0 <c>unavailable</c>              - in case further detailed information about the unmanaged road blockage is unavailable,
    /// - 1 <c>flooding          </c>       - in case the road is affected by flooding,
    /// - 2 <c>dangerOfAvalanches</c>       - in case the road is at risk of being affected or blocked by avalanches,
    /// - 3 <c>blastingOfAvalanches</c>     - in case there is an active blasting of avalanches on or near the road,
    /// - 4 <c>landslips</c>                - in case the road is affected by landslips,
    /// - 5 <c>chemicalSpillage</c>         - in case the road is affected by chemical spillage,
    /// - 6 <c>winterClosure</c>            - in case the road is impassable due to a winter closure.
    /// - 7 <c>sinkhole</c>                 - in case the road is impassable due to large holes in the road surface.
    /// - 8 <c>earthquakeDamage</c>         - in case the road is obstructed or partially obstructed because of damage caused by an earthquake.
    /// - 9 <c>fallenTrees</c>              - in case the road is obstructed or partially obstructed by one or more fallen trees.
    /// - 10 <c>rockfalls</c>               - in case the road is obstructed or partially obstructed due to fallen rocks.
    /// - 11 <c>sewerOverflow</c>           - in case the road is obstructed or partially obstructed by overflows from one or more sewers.
    /// - 12 <c>stormDamage</c>             - in case the road is obstructed or partially obstructed by debris caused by strong winds.
    /// - 13 <c>subsidence</c>              - in case the road surface has sunken or collapsed in places.
    /// - 14 <c>burstPipe</c>               - in case the road surface has sunken or collapsed in places due to burst pipes.
    /// - 15 <c>burstWaterMain</c>          - in case the road is obstructed due to local flooding and/or subsidence.
    /// - 16 <c>fallenPowerCables</c>       - in case the road is obstructed or partly obstructed by one or more fallen power cables.
    /// - 17 <c>snowDrifts</c>              - in case the road is obstructed or partially obstructed by snow drifting in progress or patches of deep snow due to earlier drifting.
    /// - 15-255                       - are reserved for future usage.
    /// </summary>
    [JsonPropertyName("impassability5")]
    [Minimum(0)]
    [Maximum(255)]
    public required int Impassability5 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
