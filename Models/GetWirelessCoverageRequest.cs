using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Get wireless coverage.
/// </summary>
public record GetWirelessCoverageRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    [JsonPropertyName("accountName")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9-]{3,32}$")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Type of request made. FWA for address qualification and NW for Nationwide coverage.
    /// </summary>
    [JsonPropertyName("requestType")]
    [StringLength(12, MinimumLength = 1)]
    [RegularExpression("^[A-Za-z]{1,12}$")]
    public required string RequestType { get; init; }

    /// <summary>
    /// Type of location detail.
    /// </summary>
    [JsonPropertyName("locationType")]
    public required string LocationType { get; init; }

    [JsonPropertyName("locations")]
    public required Locationscoord Locations { get; init; }

    [JsonPropertyName("networkTypesList")]
    [MaxLength(100)]
    public required IReadOnlyList<NetworkTypeObject> NetworkTypesList { get; init; }
}
