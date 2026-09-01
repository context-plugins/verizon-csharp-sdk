using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// error response structure
/// </summary>
public record ResponseErrorError
{
    /// <summary>
    /// The short summary of the error
    /// </summary>
    [JsonPropertyName("error")]
    [StringLength(1024, MinimumLength = 0)]
    [RegularExpression("^[\\w~\\+\\-!@#$%^&*()\\`\\[\\]{=};\\\"':,.\\\\\\/<>?|\\s]*$")]
    public required string Error { get; init; }

    /// <summary>
    /// The detailed description of the error
    /// </summary>
    [JsonPropertyName("description")]
    [StringLength(8192, MinimumLength = 0)]
    [RegularExpression("^[\\w~\\+\\-!@#$%^&*()\\`\\[\\]{=};\\\"':,.\\\\\\/<>?|\\s]*$")]
    public required string Description { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
