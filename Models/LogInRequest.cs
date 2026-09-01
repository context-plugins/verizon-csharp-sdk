using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Request to initiate a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.
/// </summary>
public record LogInRequest
{
    /// <summary>
    /// The username for authentication.
    /// </summary>
    [JsonPropertyName("username")]
    public required string Username { get; init; }

    /// <summary>
    /// The password for authentication.
    /// </summary>
    [JsonPropertyName("password")]
    public required string Password { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
