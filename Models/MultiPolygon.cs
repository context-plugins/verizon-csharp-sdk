using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// A MultiPolygon is a type of geometry that represents a collection of Polygon geometries.
/// </summary>
public record MultiPolygon
{
    [JsonPropertyName("type")]
    public required Type5 Type { get; init; }

    [JsonPropertyName("coordinates")]
    [MinLength(1)]
    [MaxLength(10)]
    public required IReadOnlyList<IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>> Coordinates { get; init; }
}
