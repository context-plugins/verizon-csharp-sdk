using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Precise location of a road sign in the WGS-84 coordinate system, from which short offsets may be used to create additional data using a flat earth projection centered on this location.
/// </summary>
public record RoadSignPosition
{
    /// <summary>
    /// The geographic latitude of an object, expressed in 1/10th integer microdegrees, as a 31 bit value, and with reference to the horizontal datum then in use. The value 900000001 shall be used when unavailable.
    /// </summary>
    [JsonPropertyName("lat")]
    [Minimum(-900000000)]
    [Maximum(900000001)]
    public required int Lat { get; init; }

    /// <summary>
    /// The geographic longitude of an object, expressed in 1/10th integer microdegrees, as a 32-bit value, and with reference to the horizontal datum then in use. The value 1800000001 shall be used when unavailable.
    /// </summary>
    [JsonPropertyName("long")]
    [Minimum(-1799999999)]
    [Maximum(1800000001)]
    public required int Long { get; init; }
}
