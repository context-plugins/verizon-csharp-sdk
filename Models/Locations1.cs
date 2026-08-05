using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Locations1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("coordinatesList")]
    public IReadOnlyList<Coordinates>? CoordinatesList { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addressList")]
    [MaxLength(100)]
    public IReadOnlyList<AddressItem>? AddressList { get; init; }
}
