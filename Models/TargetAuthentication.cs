using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// OAuth 2 token and refresh token for TS to stream events to Target.
/// </summary>
public record TargetAuthentication
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("body")]
    public TargetAuthenticationBody? Body { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public string? Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
