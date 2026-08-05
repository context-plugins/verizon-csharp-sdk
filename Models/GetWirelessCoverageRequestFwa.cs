using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Get wireless coverage FWA.
/// </summary>
public record GetWirelessCoverageRequestFwa
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
    [StringLength(12, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z]{3,12}$")]
    public required string LocationType { get; init; }

    [JsonPropertyName("locations")]
    public required Locations Locations { get; init; }

    [JsonPropertyName("networkTypesList")]
    [MaxLength(100)]
    public required IReadOnlyList<NetworkTypeObject> NetworkTypesList { get; init; }
}
