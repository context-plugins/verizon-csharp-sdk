using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Cause code wrapper for wrong way driving events.
/// </summary>
public record WrongWayDrivingCauseCode
{
    /// <summary>
    /// The value shall be set to:
    /// - 0 <c>unavailable</c>    - in case further detailed information on wrong way driving event is unavailable,
    /// - 1 <c>wrongLane</c>      - in case vehicle is driving on a lane for which it has no authorization to use,
    /// - 2 <c>wrongDirection</c> - in case vehicle is driving in a direction that it is not allowed,
    /// - 3-255              - reserved for future usage.
    /// </summary>
    [JsonPropertyName("wrongWayDriving14")]
    [Minimum(0)]
    [Maximum(255)]
    public required int WrongWayDriving14 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
