using System.Text.Json.Serialization;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

public record PayAsYouGoPricePlanTrigger
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payAsYouGo")]
    public PayAsYouGoFilterCriteria? PayAsYouGo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("condition")]
    public PayAsYouGoPricePlanTriggerCondition? Condition { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public Actionobject? Action { get; init; }
}
