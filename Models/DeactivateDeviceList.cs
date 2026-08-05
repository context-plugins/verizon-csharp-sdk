using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DeactivateDeviceList
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ids")]
    [MaxLength(100)]
    public IReadOnlyList<Id>? Ids { get; init; }
}
