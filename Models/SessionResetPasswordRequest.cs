using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request to a new, randomly generated password for the current username.
/// </summary>
public record SessionResetPasswordRequest
{
    /// <summary>
    /// The current password for the username.
    /// </summary>
    [JsonPropertyName("oldPassword")]
    public required string OldPassword { get; init; }
}
