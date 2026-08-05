using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Registered callback information.
/// </summary>
public record CallbackSummary
{
    /// <summary>
    /// Callback URL for an subscribed service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
