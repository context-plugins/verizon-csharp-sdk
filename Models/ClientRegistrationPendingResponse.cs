using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Response for /clients/registration for pending state. It provides a device_id for user to finish registration with PUT API call
/// </summary>
public record ClientRegistrationPendingResponse
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
    /// The reason why the registration is in pending state
    /// </summary>
    [JsonPropertyName("Message")]
    [StringLength(1024, MinimumLength = 0)]
    [RegularExpression("^[a-zA-Z0-9~\\+\\-!@#$%^&*()\\`\\[\\]{=};\\\"':,.\\/<>?|\\s]+$")]
    public required string Message { get; init; }
}
