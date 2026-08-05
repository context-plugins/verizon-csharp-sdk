using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// User assigned custom fields to use for fitering
/// </summary>
public record HplCustomFields
{
    /// <summary>
    /// key property
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    [StringLength(32, MinimumLength = 3)]
    public string? Key { get; init; }

    /// <summary>
    /// value of the key property
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    [StringLength(32, MinimumLength = 3)]
    public string? Value { get; init; }
}
