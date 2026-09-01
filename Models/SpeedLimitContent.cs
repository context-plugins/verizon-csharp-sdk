using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

/// <summary>
/// DataFrame content variant carrying speed limit information.
/// </summary>
public record SpeedLimitContent
{
    /// <summary>
    /// List of speed limits and cautions.
    /// </summary>
    [JsonPropertyName("speedLimit")]
    [MinLength(1)]
    [MaxLength(16)]
    public required IReadOnlyList<TextPhraseOrItis> SpeedLimit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
