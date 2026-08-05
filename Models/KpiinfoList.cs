using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record KpiinfoList
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("KpiInfoList")]
    public IReadOnlyList<Kpiinfo>? KpiInfoList { get; init; }
}
