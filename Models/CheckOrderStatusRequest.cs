using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// The request body identifies the devices to upload.
/// </summary>
public record CheckOrderStatusRequest
{
    /// <summary>
    /// The name of a billing account. An account name is usually numeric, and must include any leading zeros.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// The request id from the activation order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderRequestId")]
    public string? OrderRequestId { get; init; }

    /// <summary>
    /// The devices to upload, specified by device IDs in a format matching uploadType.
    /// </summary>
    [JsonPropertyName("devices")]
    public required IReadOnlyList<DeviceList> Devices { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
