using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Callback URL registration.
/// </summary>
public record FotaV2CallbackRegistrationRequest
{
    /// <summary>
    /// Callback URL for an subscribed service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
