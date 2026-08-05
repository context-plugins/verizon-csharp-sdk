using System.Text.Json.Serialization;

namespace Verizon.Models;

public record TriggerResponse
{
    /// <summary>
    /// The system assigned UUID of the trigger
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; init; }
}
