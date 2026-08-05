using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Authentication headers.
/// </summary>
public record TargetAuthenticationBodyHeaders
{
    /// <summary>
    /// Authorization header.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Authorization")]
    public string? Authorization { get; init; }

    /// <summary>
    /// Content-Type header.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Content-Type")]
    public string? ContentType { get; init; }
}
