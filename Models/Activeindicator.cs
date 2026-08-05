using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record Activeindicator
{
    /// <summary>
    /// A flag to indicate of the trigger is active, true, or not, false
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public Active? Active { get; init; }
}
