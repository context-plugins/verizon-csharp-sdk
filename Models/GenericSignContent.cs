using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

/// <summary>
/// DataFrame content variant carrying generic sign information.
/// </summary>
public record GenericSignContent
{
    /// <summary>
    /// List of MUTCD signs and directions.
    /// </summary>
    [JsonPropertyName("genericSign")]
    [MinLength(1)]
    [MaxLength(16)]
    public required IReadOnlyList<TextPhraseOrItis> GenericSign { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
