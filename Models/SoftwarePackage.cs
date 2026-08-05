using System;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Software package information.
/// </summary>
public record SoftwarePackage
{
    /// <summary>
    /// Software name.
    /// </summary>
    [JsonPropertyName("softwareName")]
    public required string SoftwareName { get; init; }

    /// <summary>
    /// Software launch date.
    /// </summary>
    [JsonPropertyName("launchDate")]
    public required DateTimeOffset LaunchDate { get; init; }

    /// <summary>
    /// Software release note reserved for future use.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("releaseNote")]
    public string? ReleaseNote { get; init; }

    /// <summary>
    /// Software applicable device model.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Software applicable device make.
    /// </summary>
    [JsonPropertyName("make")]
    public required string Make { get; init; }

    /// <summary>
    /// LWM2M, OMD-DM or HTTP.
    /// </summary>
    [JsonPropertyName("distributionType")]
    public required string DistributionType { get; init; }

    /// <summary>
    /// The platform (Android, iOS, etc.) that the software can be applied to.
    /// </summary>
    [JsonPropertyName("devicePlatformId")]
    public required string DevicePlatformId { get; init; }
}
