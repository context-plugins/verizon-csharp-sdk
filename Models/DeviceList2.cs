using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

public record DeviceList2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ids")]
    [MaxLength(100)]
    public IReadOnlyList<Id1>? Ids { get; init; }
}
