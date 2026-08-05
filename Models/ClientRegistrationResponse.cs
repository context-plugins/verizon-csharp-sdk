using System;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Response for /clients/registration. It provides a generated device ID and the certificates needed to connect the ETX Message Exchange.
/// </summary>
public record ClientRegistrationResponse
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
    /// Structure for the credentials required to connect to the ETX MQTT Message Exchange.
    /// </summary>
    [JsonPropertyName("Certificate")]
    public required Certificate Certificate { get; init; }
}
