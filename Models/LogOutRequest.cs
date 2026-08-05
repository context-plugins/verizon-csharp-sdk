using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request to end a Connectivity Management session.
/// </summary>
public record LogOutRequest
{
    /// <summary>
    /// The session token is returned to confirm that it was invalidated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sessionToken")]
    public string? SessionToken { get; init; }
}
