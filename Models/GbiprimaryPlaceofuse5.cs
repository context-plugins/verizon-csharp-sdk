using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record GbiprimaryPlaceofuse5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public GbiAddress5? Address { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerName")]
    public GbiCustomerName5? CustomerName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
