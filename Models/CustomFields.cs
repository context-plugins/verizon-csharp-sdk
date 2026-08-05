using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Custom data that can be included using key-value pairs.
/// </summary>
public record CustomFields
{
    /// <summary>
    /// The key for an extended attribute.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    /// <summary>
    /// The value of an extended attribute.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }
}
