using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Carrier
{
    /// <summary>
    /// The list of carriers with active or available profiles
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carriers")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9]{3,32}$")]
    public string? Carriers { get; init; }
}
