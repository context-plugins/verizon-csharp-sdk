using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record AssociateLabelRequest
{
    /// <summary>
    /// The name of a billing account. An account name is usually numeric, and must include any leading zeros.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Maximum of 2,000 objects are allowed in the array.
    /// </summary>
    [JsonPropertyName("labels")]
    public required AccountLabels Labels { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
