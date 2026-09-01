using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// A 64-bit node type with lat-long values expressed in standard SAE 1/10th of a microdegree.
/// </summary>
public record NodeLLmD64B
{
    /// <summary>
    /// The geographic longitude of an object, expressed in 1/10th integer microdegrees, as a 32-bit value, and with reference to the horizontal datum then in use. The value 1800000001 shall be used when unavailable.
    /// </summary>
    [JsonPropertyName("lon")]
    [Minimum(-1799999999)]
    [Maximum(1800000001)]
    public required int Lon { get; init; }

    /// <summary>
    /// The geographic latitude of an object, expressed in 1/10th integer microdegrees, as a 31 bit value, and with reference to the horizontal datum then in use. The value 900000001 shall be used when unavailable.
    /// </summary>
    [JsonPropertyName("lat")]
    [Minimum(-900000000)]
    [Maximum(900000001)]
    public required int Lat { get; init; }
}
