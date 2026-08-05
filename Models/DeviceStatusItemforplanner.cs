using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DeviceStatusItemforplanner
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceIds")]
    public IReadOnlyList<DeviceIdforplanner?>? DeviceIds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }
}
