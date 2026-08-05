using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A new external ID.
/// </summary>
public record GenerateExternalIdresult
{
    /// <summary>
    /// Newly created security string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("externalid")]
    public string? Externalid { get; init; }
}
