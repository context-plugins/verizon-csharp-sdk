using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Additional properties associated with data.
/// </summary>
public record ExtendedAttributes
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public string? Value { get; init; }
}
