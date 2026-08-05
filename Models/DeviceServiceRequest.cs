using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Device information.
/// </summary>
public record DeviceServiceRequest
{
    /// <summary>
    /// The International Mobile Equipment Identifier of the device.
    /// </summary>
    [JsonPropertyName("imei")]
    public required string Imei { get; init; }

    /// <summary>
    /// A flag that shows if Hyper Precise is enabled (true) or disabled (false).
    /// </summary>
    [JsonPropertyName("BullseyeEnable")]
    public required HplBullseyeEnable BullseyeEnable { get; init; }
}
