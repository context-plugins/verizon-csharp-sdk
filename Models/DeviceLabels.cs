using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A label for a single device.
/// </summary>
public record DeviceLabels
{
    /// <summary>
    /// The label you want to associate with the device.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The value of label
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }
}
