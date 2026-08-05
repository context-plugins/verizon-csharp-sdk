using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Response to a new, randomly generated password for the current username.
/// </summary>
public record SessionResetPasswordResult
{
    /// <summary>
    /// The new password for the username.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("newPassword")]
    public string? NewPassword { get; init; }
}
