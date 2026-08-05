using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The service plan code to switch to
/// </summary>
public record ChangePlanDetails
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("toCarrierServicePlanCode")]
    public string? ToCarrierServicePlanCode { get; init; }
}
