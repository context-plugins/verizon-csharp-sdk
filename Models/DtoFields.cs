using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Fields to return needed by search
/// </summary>
public record DtoFields
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalProp1")]
    public string? AdditionalProp1 { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalProp2")]
    public string? AdditionalProp2 { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalProp3")]
    public string? AdditionalProp3 { get; init; }
}
