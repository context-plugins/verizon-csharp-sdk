using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ReadySimServicePlan
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlan")]
    public string? ServicePlan { get; init; }
}
