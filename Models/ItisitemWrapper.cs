using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// A wrapper carrying an ITIS code item.
/// </summary>
public record ItisItemWrapper
{
    /// <summary>
    /// An item object wrapping an ITIS code value.
    /// </summary>
    [JsonPropertyName("item")]
    public required ItisItemContent Item { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
