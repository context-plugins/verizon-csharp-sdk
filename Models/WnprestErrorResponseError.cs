using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Wireless network performance rest error response.
/// </summary>
public record WnpRestErrorResponseError
{
    /// <summary>
    /// Rest error response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorCode")]
    [StringLength(3, MinimumLength = 3)]
    [RegularExpression("^[0-9]{3,3}$")]
    public string? ErrorCode { get; init; }

    /// <summary>
    /// Error message details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorMessage")]
    [StringLength(64, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9 ]{3,64}$")]
    public string? ErrorMessage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
