using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

public record Notify
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alertType")]
    public string? AlertType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threshold")]
    public IReadOnlyList<AccountGroupShareThreshold>? Threshold { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
