using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Get network conditions.
/// </summary>
public record GetNetworkConditionsRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    [JsonPropertyName("accountName")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9-]{3,32}$")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Type of location detail.
    /// </summary>
    [JsonPropertyName("locationType")]
    public required string LocationType { get; init; }

    /// <summary>
    /// Coordinates information.
    /// </summary>
    [JsonPropertyName("coordinates")]
    public required Coordinates Coordinates { get; init; }
}
