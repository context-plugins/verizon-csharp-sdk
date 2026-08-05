using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Host information.
/// </summary>
public record TargetAuthenticationBodyHost
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hostandpath")]
    public string? Hostandpath { get; init; }
}
