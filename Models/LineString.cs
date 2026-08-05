using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// A LineString is a type of geometry that represents a collection of points that are connected by line segments.
/// </summary>
public record LineString
{
    [JsonPropertyName("type")]
    public required Type2 Type { get; init; }

    [JsonPropertyName("coordinates")]
    [MinLength(2)]
    [MaxLength(63)]
    public required IReadOnlyList<IReadOnlyList<double>> Coordinates { get; init; }
}
