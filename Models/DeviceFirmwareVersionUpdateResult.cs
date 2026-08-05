using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Device firmware version update response.
/// </summary>
public record DeviceFirmwareVersionUpdateResult
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Request identifier.
    /// </summary>
    [JsonPropertyName("requestId")]
    public required string RequestId { get; init; }
}
