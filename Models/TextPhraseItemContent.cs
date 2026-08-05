using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// An item object wrapping a text phrase value.
/// </summary>
public record TextPhraseItemContent
{
    /// <summary>
    /// Text phrase provides very short sections of text interspersed between the ITIS codes to create phrases. In general, this is used for expressing proper nouns, such as street names reflecting local expressions that do not appear in the ITIS tables.
    /// </summary>
    [JsonPropertyName("text")]
    [StringLength(16, MinimumLength = 1)]
    [RegularExpression("^[\\w\\+\\-!()\\`\\[\\]{=};\\\"':,.\\/<>?|\\s]+$")]
    public required string Text { get; init; }
}
