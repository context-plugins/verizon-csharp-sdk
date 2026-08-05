using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Callback listener URL.
/// </summary>
public record FotaV2CallbackRegistrationResult
{
    /// <summary>
    /// Callback URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
