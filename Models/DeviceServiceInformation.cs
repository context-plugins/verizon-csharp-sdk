using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Device service information.
/// </summary>
public record DeviceServiceInformation
{
    /// <summary>
    /// ResponseCode and/or a message indicating success or failure of the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseType")]
    public ApiResponseCode? ResponseType { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
