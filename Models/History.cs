using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// History data for a selected device and its attributes at a specific time.
/// </summary>
public record History
{
    /// <summary>
    /// The name of the billing account for which you want retrieve history data. An account name is usually numeric, and must include any leading zeros.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Identifies a particular IoT device.
    /// </summary>
    [JsonPropertyName("device")]
    public required Device Device { get; init; }

    /// <summary>
    /// Streaming RF parameter for which you want to retrieve history data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attributes")]
    public HistoryAttributeValue? Attributes { get; init; }
}
