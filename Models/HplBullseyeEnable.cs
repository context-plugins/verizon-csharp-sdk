using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A flag that shows if Hyper Precise is enabled (true) or disabled (false).
/// </summary>
public record HplBullseyeEnable
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("BullseyeEnable")]
    public bool? BullseyeEnable { get; init; }
}
