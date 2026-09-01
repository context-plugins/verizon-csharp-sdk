using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record ReadySimServicePlan
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlan")]
    public string? ServicePlan { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
