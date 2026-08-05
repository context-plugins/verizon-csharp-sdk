using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The NodeListLL data structure provides the sequence of signed offset node point values for determining the latitude and longitude. Each LL point is referred to as a node point.
/// </summary>
public record NodeListLl
{
    /// <summary>
    /// The NodeSetLL data frame consists of a list of NodeLL entries using LL offsets.
    /// </summary>
    [JsonPropertyName("nodes")]
    [MinLength(2)]
    [MaxLength(63)]
    public required IReadOnlyList<NodeLl> Nodes { get; init; }
}
