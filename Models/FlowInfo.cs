using System.Text.Json.Serialization;

namespace Verizon.Models;

public record FlowInfo
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flowServer")]
    public string? FlowServer { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flowDevice")]
    public string? FlowDevice { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flowDirection")]
    public string? FlowDirection { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flowProtocol")]
    public string? FlowProtocol { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qciOption")]
    public string? QciOption { get; init; }
}
