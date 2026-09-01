using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// PWN Performance Consent Response
/// </summary>
public record GetPwnPerformanceConsentResponse
{
    /// <summary>
    /// PWN Performance Consent Response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consent")]
    public string? Consent { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
