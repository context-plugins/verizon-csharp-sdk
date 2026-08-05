using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Callback registration information.
/// </summary>
public record FotaV3CallbackSummary
{
    /// <summary>
    /// Callback URL for an subscribed service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
