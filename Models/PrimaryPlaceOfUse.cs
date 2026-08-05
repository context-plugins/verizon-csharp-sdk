using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record PrimaryPlaceOfUse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerName")]
    [MaxLength(5)]
    public IReadOnlyList<CustomerName>? CustomerName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    [MaxLength(5)]
    public IReadOnlyList<Address>? Address { get; init; }
}
