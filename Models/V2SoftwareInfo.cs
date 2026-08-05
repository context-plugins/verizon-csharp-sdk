using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Software information.
/// </summary>
public record V2SoftwareInfo
{
    /// <summary>
    /// Software name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Software version.
    /// </summary>
    [JsonPropertyName("version")]
    public required string Version { get; init; }

    /// <summary>
    /// Upgrade time.
    /// </summary>
    [JsonPropertyName("upgradeTime")]
    public required string UpgradeTime { get; init; }
}
