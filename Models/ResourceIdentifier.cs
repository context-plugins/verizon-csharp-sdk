using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}.
/// </summary>
public record ResourceIdentifier
{
    /// <summary>
    /// Target ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Device IMEI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("imei")]
    public string? Imei { get; init; }
}
