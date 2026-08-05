using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// PWN Performance Consent Response
/// </summary>
public record GetPwnperformanceConsentResponse
{
    /// <summary>
    /// PWN Performance Consent Response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consent")]
    public string? Consent { get; init; }
}
