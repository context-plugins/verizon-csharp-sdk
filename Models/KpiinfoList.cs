using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record KpiInfoList
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("KpiInfoList")]
    public IReadOnlyList<KpiInfo>? KpiInfoListValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
