using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// A wrapper carrying a text phrase item.
/// </summary>
public record TextPhraseItemWrapper
{
    /// <summary>
    /// An item object wrapping a text phrase value.
    /// </summary>
    [JsonPropertyName("item")]
    public required TextPhraseItemContent Item { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
