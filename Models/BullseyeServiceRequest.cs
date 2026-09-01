using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Account number and list of devices.
/// </summary>
public record BullseyeServiceRequest
{
    /// <summary>
    /// A list of devices.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<DeviceServiceRequest> DeviceList { get; init; }

    /// <summary>
    /// The numeric ID of the account and must include leading zeroes. This value is indentical to <c>accountName</c>.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
