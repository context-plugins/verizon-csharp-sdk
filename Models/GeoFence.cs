using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// The GeoJSON representation of geofence. Geofence supports the following geometry types: LineString, Polygon, MultiLineString, and MultiPolygon. The system only supports a single Feature in the FeatureCollection, so only one Line, Polygon, MultiLine or MultiPolygon can be defined within one Geofencing configuration.
/// </summary>
public record GeoFence
{
    [JsonPropertyName("type")]
    public required TypeEnum Type { get; init; }

    [JsonPropertyName("features")]
    [MinLength(1)]
    [MaxLength(1)]
    public required IReadOnlyList<FeatureItem> Features { get; init; }
}
