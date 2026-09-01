using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Contains usage information per device.
/// </summary>
public record AggregateUsageItem
{
    /// <summary>
    /// The International Mobile Equipment Identifier of the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("imei")]
    public string? Imei { get; init; }

    /// <summary>
    /// Number of sessions established by the device reporting usage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberOfSessions")]
    public int? NumberOfSessions { get; init; }

    /// <summary>
    /// The amount of data transferred by the device reporting usage, measured in Bytes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bytesTransferred")]
    public int? BytesTransferred { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
