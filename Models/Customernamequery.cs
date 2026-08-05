using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Customernamequery
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerName")]
    [MaxLength(5)]
    public IReadOnlyList<CustomerName>? CustomerName { get; init; }
}
