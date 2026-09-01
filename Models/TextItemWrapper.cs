using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// A wrapper carrying a text item.
/// </summary>
public record TextItemWrapper
{
    /// <summary>
    /// An item object wrapping a text value.
    /// </summary>
    [JsonPropertyName("item")]
    public required TextItemContent Item { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
