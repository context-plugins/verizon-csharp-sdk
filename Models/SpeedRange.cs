using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Acceptable speed range for road users in m/s.
/// </summary>
public record SpeedRange
{
    /// <summary>
    /// The minimum required speed in m/s.
    /// </summary>
    [JsonPropertyName("min")]
    [Minimum(0.0)]
    [Maximum(160.0)]
    public required double Min { get; init; }

    /// <summary>
    /// The maximum acceptable speed in m/s.
    /// </summary>
    [JsonPropertyName("max")]
    [Minimum(0.0)]
    [Maximum(160.0)]
    public required double Max { get; init; }
}
