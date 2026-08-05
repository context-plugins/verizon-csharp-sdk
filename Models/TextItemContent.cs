using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// An item object wrapping a text value.
/// </summary>
public record TextItemContent
{
    /// <summary>
    /// Simple text used with ITIS codes. (Text taken from SAE J2540.)
    /// </summary>
    [JsonPropertyName("text")]
    [StringLength(500, MinimumLength = 1)]
    [RegularExpression("^[\\w\\+\\-!()\\`\\[\\]{=};\\\"':,.\\/<>?|\\s]+$")]
    public required string Text { get; init; }
}
