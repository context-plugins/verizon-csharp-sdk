using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// A response to a successful request contains a single Boolean value.
/// </summary>
public record FotaV1SuccessResult
{
    /// <summary>
    /// True is returned in case of success.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public bool? Success { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
