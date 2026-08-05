using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Pagination filter containing an opaque token for fetching the next/previous page of results.
/// The page token is returned in the response headers (X-Next, X-Prev) and should be passed as-is.
/// </summary>
public record PaginationFilter
{
    /// <summary>
    /// Opaque pagination token for fetching the next/previous page of results.
    /// This is a encoded string. Do not parse or modify; pass it as received.
    /// </summary>
    [JsonPropertyName("Page")]
    [MaxLength(4096)]
    [RegularExpression("^[A-Za-z0-9_-]+={0,2}$")]
    public required string Page { get; init; }
}
