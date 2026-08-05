using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GbiaddressAndcustomerinfo5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryPlaceofuse")]
    public GbiprimaryPlaceofuse5? PrimaryPlaceofuse { get; init; }
}
