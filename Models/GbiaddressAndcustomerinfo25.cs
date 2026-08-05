using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GbiaddressAndcustomerinfo25
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryPlaceofuse")]
    public GbiaddressAndcustomerinfo5? PrimaryPlaceofuse { get; init; }
}
