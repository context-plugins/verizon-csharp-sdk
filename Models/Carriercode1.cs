using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Carriercode1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierCode")]
    public string? CarrierCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentage")]
    public AllowanceThreshold? Percentage { get; init; }
}
