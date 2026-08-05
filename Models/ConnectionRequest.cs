using System;
using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Request for /clients/connection. It requires the device ID acquired in the registration request call; the geolocation of the device at the time of the request; and the network type (Verizon or non-Verizon). The system uses this information to determine with MQTT endpoint the device should use to connect the ETX Message Exchange.
/// </summary>
public record ConnectionRequest
{
    /// <summary>
    /// The generated ID (UUID v4) for the device. It can be used as:
    ///   - the MQTT Client ID when connecting to the Message Exchange system
    ///   - a parameter when asking for the connection endpoint
    ///   - a parameter when finishing the device registration
    ///   - a parameter when unregistering the device
    /// </summary>
    [JsonPropertyName("DeviceID")]
    public required Guid DeviceId { get; init; }

    /// <summary>
    /// Geolocation of the device at the time of the connection request in GPS coordinates.
    /// </summary>
    [JsonPropertyName("Geolocation")]
    public required Geolocation Geolocation { get; init; }

    /// <summary>
    /// The type of the device's network connection at the time of the request. If the device is on the Verizon cellular network it should use the "VZ" value otherwise the "non-VZ" value.
    /// <para>
    /// Devices on the Verizon network can directly access the ETX Message Exchange on the MEC (Mobile Edge Compute server)
    /// </para>
    /// </summary>
    [JsonPropertyName("NetworkType")]
    public required NetworkType NetworkType { get; init; }
}
