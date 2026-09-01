using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

public record EventPosition
{
    /// <summary>
    /// Latitude of the event location in microdegrees (900000001 shall be used when unavailable).
    /// </summary>
    [JsonPropertyName("latitude")]
    [Minimum(-900000000)]
    [Maximum(900000001)]
    public required int Latitude { get; init; }

    /// <summary>
    /// Longitude of the event location in microdegrees (1800000001 shall be used when unavailable).
    /// </summary>
    [JsonPropertyName("longitude")]
    [Minimum(-1800000000)]
    [Maximum(1800000001)]
    public required int Longitude { get; init; }

    [JsonPropertyName("positionConfidenceEllipse")]
    public required PosConfidenceEllipse PositionConfidenceEllipse { get; init; }

    [JsonPropertyName("altitude")]
    public required Altitude Altitude { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
