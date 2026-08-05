using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Fields and values to match.
/// </summary>
public record QuerySubscriptionRequest
{
    /// <summary>
    /// The ID of the authenticating billing account, in the format <c>{"billingaccountid":"1234567890-12345"}</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountidentifier")]
    public AccountIdentifier? Accountidentifier { get; init; }

    /// <summary>
    /// A comma-separated list of properties and comparator values to match against subscriptions in the ThingSpace account. See Working with Query Filters for more information. If the request does not include <c>$selection</c>, the response will include all subscriptions to which the requesting user has access.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$selection")]
    public IReadOnlyDictionary<string, string>? Selection { get; init; }

    /// <summary>
    /// The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resourceidentifier")]
    public ResourceIdentifier? Resourceidentifier { get; init; }
}
