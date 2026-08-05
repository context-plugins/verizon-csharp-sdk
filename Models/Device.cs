using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Identifies a particular IoT device.
/// </summary>
public record Device
{
    /// <summary>
    /// Device identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Device kind identifier.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; init; }
}
