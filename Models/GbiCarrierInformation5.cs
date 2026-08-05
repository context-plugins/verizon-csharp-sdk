using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GbiCarrierInformation5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierName")]
    public string? CarrierName { get; init; }
}
