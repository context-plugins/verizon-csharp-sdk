using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Streaming RF parameters for which you want to retrieve history data.
/// </summary>
public record HistorySearchFilterAttributes
{
    /// <summary>
    /// Attribute identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public AttributeIdentifier? Name { get; init; }
}
