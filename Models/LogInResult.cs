using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Response to initiate a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.
/// </summary>
public record LogInResult
{
    /// <summary>
    /// The identifier for the session that was created by the request. Store the sessionToken for use in the header of all other API requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sessionToken")]
    public string? SessionToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
