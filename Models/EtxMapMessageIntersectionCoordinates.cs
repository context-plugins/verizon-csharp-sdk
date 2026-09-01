using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Core.Validation.Attributes;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Query MAP records using specific region and intersection identifier pairs
/// </summary>
public record EtxMapMessageIntersectionCoordinates
{
    /// <summary>
    /// V2X messaging standard selection. Accepted values are 'sae' (SAE J2735) and 'etsi' (ETSI TS 103 301).
    /// </summary>
    [JsonPropertyName("messageStandard")]
    public EtxMessageStandardEnum? MessageStandard { get; init; } = EtxMessageStandardEnum.Sae;

    /// <summary>
    /// List of region and intersection ID pairs to retrieve MAP messages for.
    /// </summary>
    [JsonPropertyName("regionIntersectionPairs")]
    [MaxLength(200)]
    public required IReadOnlyList<RegionIntersectionPair> RegionIntersectionPairs { get; init; }

    /// <summary>
    /// The format of the payload in the response body.
    /// </summary>
    [JsonPropertyName("expectedType")]
    public EtxExpectedTypeEnum? ExpectedType { get; init; } = EtxExpectedTypeEnum.Base64;

    /// <summary>
    /// Base64 encoded token used to retrieve the next page of results
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pageToken")]
    [MaxLength(500)]
    [RegularExpression("^[A-Za-z0-9+/]+=*$")]
    public string? PageToken { get; init; }

    /// <summary>
    /// Maximum number of records to return in a single page
    /// </summary>
    [JsonPropertyName("pageSize")]
    [Minimum(1)]
    [Maximum(500)]
    public int? PageSize { get; init; } = 200;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
