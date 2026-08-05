using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record Suspenddetailsobject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suspendFromAccounts")]
    public IReadOnlyList<string>? SuspendFromAccounts { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suspendDuration")]
    public int? SuspendDuration { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suspendOption")]
    public string? SuspendOption { get; init; }

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
}
