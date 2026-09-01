using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record TriggerResponse
{
    /// <summary>
    /// The system assigned UUID of the trigger
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
