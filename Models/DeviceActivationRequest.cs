using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request for device status to check availability of activation.
/// </summary>
public record DeviceActivationRequest
{
    /// <summary>
    /// The name of a billing account.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Up to 10,000 devices that you want to move to a different account, specified by device identifier.
    /// </summary>
    [JsonPropertyName("devices")]
    public required IReadOnlyList<AccountDeviceList> Devices { get; init; }
}
