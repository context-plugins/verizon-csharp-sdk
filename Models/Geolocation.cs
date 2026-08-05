using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Geolocation of the device at the time of the connection request in GPS coordinates.
/// </summary>
public record Geolocation
{
    /// <summary>
    /// The GPS Latitude value
    /// </summary>
    [JsonPropertyName("Latitude")]
    [Minimum(-90.0)]
    [Maximum(90.0)]
    public required double Latitude { get; init; }

    /// <summary>
    /// The GPS Longitude value
    /// </summary>
    [JsonPropertyName("Longitude")]
    [Minimum(-180.0)]
    [Maximum(180.0)]
    public required double Longitude { get; init; }
}
