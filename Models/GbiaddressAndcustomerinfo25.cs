using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record GbiaddressAndcustomerinfo25
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryPlaceofuse")]
    public GbiaddressAndcustomerinfo5? PrimaryPlaceofuse { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
