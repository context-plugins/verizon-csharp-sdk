using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Response to change PWN device ip address.
/// </summary>
public record ChangePwnDeviceIpAddressResponse
{
    /// <summary>
    /// A unique string that associates the request with the results that are sent via a callback service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    public string? RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
