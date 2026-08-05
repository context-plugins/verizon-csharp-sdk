using System.Text.Json.Serialization;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

/// <summary>
/// Response for a request made to delete a device.
/// </summary>
public record DeleteDevicesResult
{
    /// <summary>
    /// One object per device to be deleted. Each object must contain a kind and id element identifying the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceIds")]
    public DeviceIds? DeviceIds { get; init; }

    /// <summary>
    /// “Success” if the device was deleted, or “Failed” if there was a problem.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// Not present if status=Success. One of these messages if status=Failed:The device is not in deactivate state.The user does not have access to delete the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }
}
