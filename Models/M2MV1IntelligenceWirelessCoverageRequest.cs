using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record M2MV1IntelligenceWirelessCoverageRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9-]{3,32}$")]
    public string? AccountName { get; init; }

    /// <summary>
    /// Type of request made. FWA for address qualification and NW for Nationwide coverage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestType")]
    [StringLength(12, MinimumLength = 1)]
    [RegularExpression("^[A-Za-z]{1,12}$")]
    public string? RequestType { get; init; }

    /// <summary>
    /// Type of location detail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locationType")]
    [StringLength(12, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z]{3,12}$")]
    public string? LocationType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locations")]
    public Locations1? Locations { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkTypesList")]
    [MaxLength(100)]
    public IReadOnlyList<NetworkTypeObject>? NetworkTypesList { get; init; }
}
