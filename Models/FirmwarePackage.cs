using System;
using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Available firmware.
/// </summary>
public record FirmwarePackage
{
    /// <summary>
    /// Firmware name.
    /// </summary>
    [JsonPropertyName("firmwareName")]
    public required string FirmwareName { get; init; }

    /// <summary>
    /// Firmware from version.
    /// </summary>
    [JsonPropertyName("firmwareFrom")]
    public required string FirmwareFrom { get; init; }

    /// <summary>
    /// Firmware to version.
    /// </summary>
    [JsonPropertyName("firmwareTo")]
    public required string FirmwareTo { get; init; }

    /// <summary>
    /// Firmware launch date.
    /// </summary>
    [JsonPropertyName("launchDate")]
    public required DateTimeOffset LaunchDate { get; init; }

    /// <summary>
    /// Firmware release note.
    /// </summary>
    [JsonPropertyName("releaseNote")]
    public required string ReleaseNote { get; init; }

    /// <summary>
    /// Firmware applicable device model.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Firmware applicable device make.
    /// </summary>
    [JsonPropertyName("make")]
    public required string Make { get; init; }

    /// <summary>
    /// Firmware protocol. Valid values include: LWM2M, OMD-DM.
    /// </summary>
    [JsonPropertyName("protocol")]
    public CampaignMetaInfoProtocol Protocol { get; init; } = CampaignMetaInfoProtocol.Lwm2M;
}
