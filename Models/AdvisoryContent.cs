using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

/// <summary>
/// DataFrame content variant carrying advisory ITIS codes.
/// </summary>
public record AdvisoryContent
{
    /// <summary>
    /// List of typical ITIS warnings.
    /// </summary>
    [JsonPropertyName("advisory")]
    [MinLength(1)]
    [MaxLength(100)]
    public required IReadOnlyList<AdvisoryItem> Advisory { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
