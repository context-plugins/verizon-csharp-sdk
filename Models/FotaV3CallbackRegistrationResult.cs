using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Callback registration information.
/// </summary>
public record FotaV3CallbackRegistrationResult
{
    /// <summary>
    /// Callback URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
