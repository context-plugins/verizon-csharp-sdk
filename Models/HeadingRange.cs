using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Acceptable heading range for road users in degrees.
/// </summary>
public record HeadingRange
{
    /// <summary>
    /// The minimum value of heading in unit of degrees.
    /// </summary>
    [JsonPropertyName("min")]
    [Minimum(0.0)]
    [Maximum(360.0)]
    public required double Min { get; init; }

    /// <summary>
    /// The maximum value of heading in unit of degrees.
    /// </summary>
    [JsonPropertyName("max")]
    [Minimum(0.0)]
    [Maximum(360.0)]
    public required double Max { get; init; }
}
