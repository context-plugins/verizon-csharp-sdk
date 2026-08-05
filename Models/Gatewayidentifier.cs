using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Gatewayidentifier
{
    /// <summary>
    /// a unique parent deviceid used to group all Lora sensors. Sensors need parent gateway for connection
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceid")]
    public string? Deviceid { get; init; }
}
