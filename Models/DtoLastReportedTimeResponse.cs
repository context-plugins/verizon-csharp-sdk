using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoLastReportedTimeResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event")]
    public ResourceEvent? Event { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; init; }
}
