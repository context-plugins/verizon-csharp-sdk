using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Core.Validation.Attributes;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Query MAP records using a GeoJSON polygon to define the spatial area
/// </summary>
public record EtxMapMessageGeoJsonPolygon
{
    /// <summary>
    /// V2X messaging standard selection. Accepted values are 'sae' (SAE J2735) and 'etsi' (ETSI TS 103 301).
    /// </summary>
    [JsonPropertyName("messageStandard")]
    public EtxMessageStandardEnum? MessageStandard { get; init; } = EtxMessageStandardEnum.Sae;

    /// <summary>
    /// GeoJSON Polygon defining the area to retrieve MAP messages for.
    /// </summary>
    [JsonPropertyName("geoJson")]
    public required object GeoJson { get; init; }

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
