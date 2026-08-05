using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Identifier object pairs of kind/id
/// </summary>
public record HplDeviceId
{
    /// <summary>
    /// The type of ID. This can be IMEI or ICCID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kind")]
    public string? Kind { get; init; }

    /// <summary>
    /// The ID value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }
}
