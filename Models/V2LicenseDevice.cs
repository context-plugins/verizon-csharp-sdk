using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Device IMEI list.
/// </summary>
public record V2LicenseDevice
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
