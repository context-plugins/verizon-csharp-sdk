using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Status of Hyper Precise Location on the device.
/// </summary>
public record BullseyeServiceResult
{
    /// <summary>
    /// The numeric ID of the account and must include leading zeroes. This value is indentical to <c>accountName</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; init; }

    /// <summary>
    /// List of devices.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceList")]
    public IReadOnlyList<DeviceServiceInformation>? DeviceList { get; init; }

    /// <summary>
    /// ResponseCode and/or a message indicating success or failure of the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseType")]
    public ApiResponseCode? ResponseType { get; init; }
}
