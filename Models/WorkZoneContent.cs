using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

/// <summary>
/// DataFrame content variant carrying work zone information.
/// </summary>
public record WorkZoneContent
{
    /// <summary>
    /// List of work zone signs and directions.
    /// </summary>
    [JsonPropertyName("workZone")]
    [MinLength(1)]
    [MaxLength(16)]
    public required IReadOnlyList<TextPhraseOrItis> WorkZone { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
