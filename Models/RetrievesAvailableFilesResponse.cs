using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record RetrievesAvailableFilesResponse
{
    /// <summary>
    /// ThingSpace-generated name of the file. You will use this name when listing or scheduling campaigns for the file.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fileName")]
    public string? FileName { get; init; }

    /// <summary>
    /// Version of the file.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fileVersion")]
    public string? FileVersion { get; init; }

    /// <summary>
    /// Software release note.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("releaseNote")]
    public string? ReleaseNote { get; init; }

    /// <summary>
    /// The software-applicable device make.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("make")]
    public string? Make { get; init; }

    /// <summary>
    /// The software-applicable device model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model")]
    public string? Model { get; init; }

    /// <summary>
    /// Local target path on the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("localTargetPath")]
    public string? LocalTargetPath { get; init; }

    /// <summary>
    /// Valid values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distributionType")]
    public string? DistributionType { get; init; }

    /// <summary>
    /// The platform (Android, iOS, etc.,) that the software can be applied to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devicePlatformId")]
    public string? DevicePlatformId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
