using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Device IMEI.
/// </summary>
public record V3LicenseDevice
{
    /// <summary>
    /// Device IMEI.
    /// </summary>
    [JsonPropertyName("deviceId")]
    public required string DeviceId { get; init; }

    /// <summary>
    /// License assignment time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assignmentTime")]
    public string? AssignmentTime { get; init; }
}
