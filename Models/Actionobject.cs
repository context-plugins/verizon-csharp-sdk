using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Actionobject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suspendDetails")]
    public Suspenddetailsobject? SuspendDetails { get; init; }

    /// <summary>
    /// a flag to set if the trigger changes service plans, true, or not, false
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("changePlan")]
    public bool? ChangePlan { get; init; }

    /// <summary>
    /// The service plan code to switch to
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("changePlanDetails")]
    public ChangePlanDetails? ChangePlanDetails { get; init; }
}
