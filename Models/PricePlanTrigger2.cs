using System.Text.Json.Serialization;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

public record PricePlanTrigger2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountShare")]
    public AccountShareFilterCriteria? AccountShare { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("condition")]
    public AccountSharePricePlanTriggerCondition? Condition { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payAsYouGo")]
    public PayAsYouGoFilterCriteria? PayAsYouGo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public Actionobject? Action { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("standAlone")]
    public FiltercriteriaObjectCall? StandAlone { get; init; }
}
