using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Response to a callback action.
/// </summary>
public record CallbackActionResult
{
    /// <summary>
    /// The name of the billing account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The name of the callback service that was registered/deregistered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; init; }
}
