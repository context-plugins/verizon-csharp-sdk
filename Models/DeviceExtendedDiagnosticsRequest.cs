using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request for obtaining device extended diagnostics.
/// </summary>
public record DeviceExtendedDiagnosticsRequest
{
    /// <summary>
    /// The Verizon billing account that the device belongs to. An account name is usually numeric, and must include any leading zeros.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// The device for which you want diagnostic information, specified by the device's MDN.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<DeviceId> DeviceList { get; init; }
}
