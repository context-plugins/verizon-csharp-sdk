using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Location details.
/// </summary>
public record Locations
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addressList")]
    [MaxLength(100)]
    public IReadOnlyList<AddressItem>? AddressList { get; init; }
}
