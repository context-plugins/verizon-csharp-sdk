using System;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Firmware information.
/// </summary>
public record Firmware
{
    /// <summary>
    /// The name of the firmware image, provided by the device manufacturer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firmwareName")]
    public string? FirmwareName { get; init; }

    /// <summary>
    /// Internal reference; can be ignored.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("participantName")]
    public string? ParticipantName { get; init; }

    /// <summary>
    /// The release date of the firmware image.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("launchDate")]
    public DateTimeOffset? LaunchDate { get; init; }

    /// <summary>
    /// Additional information about the release.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("releaseNote")]
    public string? ReleaseNote { get; init; }

    /// <summary>
    /// The device model that the firmware applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model")]
    public string? Model { get; init; }

    /// <summary>
    /// The device make that the firmware applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("make")]
    public string? Make { get; init; }

    /// <summary>
    /// The firmware version that must currently be on the device to upgrade.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fromVersion")]
    public string? FromVersion { get; init; }

    /// <summary>
    /// The firmware version that will be on the device after an upgrade.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("toVersion")]
    public string? ToVersion { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
