using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// A MultiLineString is a type of geometry that represents a collection of LineString geometries.
/// </summary>
public record MultiLineString
{
    [JsonPropertyName("type")]
    public required Type4 Type { get; init; }

    [JsonPropertyName("coordinates")]
    [MinLength(1)]
    [MaxLength(10)]
    public required IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>> Coordinates { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
