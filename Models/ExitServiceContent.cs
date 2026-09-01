using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

/// <summary>
/// DataFrame content variant carrying exit service information.
/// </summary>
public record ExitServiceContent
{
    /// <summary>
    /// List of roadside available services.
    /// </summary>
    [JsonPropertyName("exitService")]
    [MinLength(1)]
    [MaxLength(16)]
    public required IReadOnlyList<TextPhraseOrItis> ExitService { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
