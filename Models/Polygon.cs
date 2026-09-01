using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// A Polygon is a type of geometry that represents a collection of points that form a closed ring.
/// <para>
/// NOTE: This API only supports a single polygon in the Polygon geometry, so holes cannot be defines at this point. Support for hole will be added in future releases.
/// </para>
/// </summary>
public record Polygon
{
    [JsonPropertyName("type")]
    public required Type3 Type { get; init; }

    [JsonPropertyName("coordinates")]
    [MinLength(1)]
    [MaxLength(1)]
    public required IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>> Coordinates { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
