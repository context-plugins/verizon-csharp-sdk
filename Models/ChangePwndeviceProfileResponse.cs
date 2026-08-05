using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Response to change PWN device profile
/// </summary>
public record ChangePwndeviceProfileResponse
{
    /// <summary>
    /// A unique string that associates the request with the results that are sent via a callback service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    public string? RequestId { get; init; }
}
