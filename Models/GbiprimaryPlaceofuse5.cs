using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GbiprimaryPlaceofuse5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public GbiAddress5? Address { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerName")]
    public GbiCustomerName5? CustomerName { get; init; }
}
