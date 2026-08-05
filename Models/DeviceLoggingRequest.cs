using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Device logging information.
/// </summary>
public record DeviceLoggingRequest
{
    /// <summary>
    /// List of device IMEI identifiers.
    /// </summary>
    [JsonPropertyName("deviceIds")]
    public required IReadOnlyList<string> DeviceIds { get; init; }
}
