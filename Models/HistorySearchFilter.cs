using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// The selected device and attributes for which a request should retrieve data.
/// </summary>
public record HistorySearchFilter
{
    /// <summary>
    /// Account name identifier.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Identifies a particular IoT device.
    /// </summary>
    [JsonPropertyName("device")]
    public required Device Device { get; init; }

    /// <summary>
    /// Streaming RF parameters for which you want to retrieve history data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attributes")]
    public HistorySearchFilterAttributes? Attributes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
