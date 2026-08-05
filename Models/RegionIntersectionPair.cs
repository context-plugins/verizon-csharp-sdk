using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Specific region and intersection identification pair
/// </summary>
public record RegionIntersectionPair
{
    /// <summary>
    /// The region identifier code (0-65535)
    /// </summary>
    [JsonPropertyName("regionId")]
    [Minimum(0)]
    [Maximum(65535)]
    public int? RegionId { get; init; } = 0;

    /// <summary>
    /// The intersection identifier code (0-65535)
    /// </summary>
    [JsonPropertyName("intersectionId")]
    [Minimum(0)]
    [Maximum(65535)]
    public required int IntersectionId { get; init; }
}
