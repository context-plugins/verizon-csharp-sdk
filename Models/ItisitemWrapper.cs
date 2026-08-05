using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A wrapper carrying an ITIS code item.
/// </summary>
public record ItisitemWrapper
{
    /// <summary>
    /// An item object wrapping an ITIS code value.
    /// </summary>
    [JsonPropertyName("item")]
    public required ItisitemContent Item { get; init; }
}
