using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Search Device By Property resource definition.
/// </summary>
public record SearchSensorHistoryRequest
{
    /// <summary>
    /// The ID of the authenticating billing account, in the format <c>{"billingaccountid":"1234567890-12345"}</c>.
    /// </summary>
    [JsonPropertyName("accountidentifier")]
    public required AccountIdentifier Accountidentifier { get; init; }

    /// <summary>
    /// The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}.
    /// </summary>
    [JsonPropertyName("resourceidentifier")]
    public required ResourceIdentifier Resourceidentifier { get; init; }

    /// <summary>
    /// The maximum number of events to include in the response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$limitnumber")]
    public int? Limitnumber { get; init; }

    /// <summary>
    /// The maximum number of events to include in the response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$page")]
    public string? Page { get; init; }
}
