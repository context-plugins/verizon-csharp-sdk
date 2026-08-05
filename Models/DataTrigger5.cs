using System.Text.Json.Serialization;
using Verizon.Models.AnyOf;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record DataTrigger5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterCriteria")]
    public AccountLevelFilter? FilterCriteria { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("condition")]
    public AccountLevelObjectcondition? Condition { get; init; }

    /// <summary>
    /// The action taken when trigger conditions are met
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public AccountLevelAction? Action { get; init; }

    /// <summary>
    /// The condition type being monitored
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("conditionType")]
    public ConditionType? ConditionType { get; init; }

    /// <summary>
    /// The boolean of the comparison. <c>gt</c> is Greater Than, <c>lt</c> is Less Than and <c>eq</c> is Equal To
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("comparitor")]
    public Comparitor? Comparitor { get; init; }

    /// <summary>
    /// The threshold value the trigger monitors for
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threshold")]
    public int? Threshold { get; init; }

    /// <summary>
    /// The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thresholdUnit")]
    public ThresholdUnit? ThresholdUnit { get; init; }

    /// <summary>
    /// The interval to monitor for the threshold. This can be Daily, Weekly or Monthly
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cycleType")]
    public RulesCycleType? CycleType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowanceThreshold")]
    public AllowanceThreshold? AllowanceThreshold { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceGroup")]
    public DeviceGroupFilterCriteria? DeviceGroup { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountGroupShare")]
    public AccountGroupShareIndividual1? AccountGroupShare { get; init; }
}
