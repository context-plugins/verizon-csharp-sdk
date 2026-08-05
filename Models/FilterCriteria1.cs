using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record FilterCriteria1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierServicePlanCode")]
    public string? CarrierServicePlanCode { get; init; }

    /// <summary>
    /// An array of account names
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountNameList")]
    public IReadOnlyList<string>? AccountNameList { get; init; }
}
