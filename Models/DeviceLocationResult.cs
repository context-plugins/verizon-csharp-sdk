using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Will be empty if there was no error.
/// </summary>
public record DeviceLocationResult
{
    [JsonPropertyName("errorCode")]
    public required string ErrorCode { get; init; }

    [JsonPropertyName("errorMessage")]
    public required string ErrorMessage { get; init; }
}
