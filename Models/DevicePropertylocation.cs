using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DevicePropertylocation
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latitude")]
    public string? Latitude { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("longitude")]
    public string? Longitude { get; init; }
}
