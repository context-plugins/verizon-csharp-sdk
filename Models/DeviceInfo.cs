using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// The devices that you want to locate. The array cannot contain more than 20 devices.
/// </summary>
public record DeviceInfo
{
    /// <summary>
    /// Device identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Device identifier kind.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; init; }

    /// <summary>
    /// Device MDN.
    /// </summary>
    [JsonPropertyName("mdn")]
    public required string Mdn { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
