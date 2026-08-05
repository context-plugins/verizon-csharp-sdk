using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GiodeviceList
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceIds")]
    [MaxLength(100)]
    public IReadOnlyList<GiodeviceId>? DeviceIds { get; init; }
}
