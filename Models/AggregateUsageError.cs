using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Error reported by a device.
/// </summary>
public record AggregateUsageError
{
    /// <summary>
    /// The International Mobile Equipment Identifier of the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("imei")]
    public string? Imei { get; init; }

    /// <summary>
    /// A general error message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; init; }

    /// <summary>
    /// Error message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorResponse")]
    public IerrorMessage? ErrorResponse { get; init; }
}
