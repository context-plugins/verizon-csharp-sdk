using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record GbiCarrierInformation5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierName")]
    public string? CarrierName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
