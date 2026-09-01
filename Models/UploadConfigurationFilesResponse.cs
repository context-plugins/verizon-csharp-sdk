using System;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record UploadConfigurationFilesResponse
{
    /// <summary>
    /// The name of the file you are upgrading to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fileName")]
    public string? FileName { get; init; }

    /// <summary>
    /// The version of the file you are upgrading to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fileVersion")]
    public string? FileVersion { get; init; }

    /// <summary>
    /// Software launch date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("launchDate")]
    public DateTimeOffset? LaunchDate { get; init; }

    /// <summary>
    /// Software release note.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("releaseNote")]
    public string? ReleaseNote { get; init; }

    /// <summary>
    /// Software applicable device model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model")]
    public string? Model { get; init; }

    /// <summary>
    /// Software applicable device make.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("make")]
    public string? Make { get; init; }

    /// <summary>
    /// LWM2M, OMD-DM or HTTP.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distributionType")]
    public string? DistributionType { get; init; }

    /// <summary>
    /// The platform (Android, iOS, etc.) that the software can be applied to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devicePlatformId")]
    public string? DevicePlatformId { get; init; }

    /// <summary>
    /// Local target path on the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("localTargetPath")]
    public string? LocalTargetPath { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
