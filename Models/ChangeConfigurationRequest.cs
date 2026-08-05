using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The request body identifies the device and the values to set.
/// </summary>
public record ChangeConfigurationRequest
{
    /// <summary>
    /// The ID of the authenticating billing account, in the format <c>{"billingaccountid":"1234567890-12345"}</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountidentifier")]
    public AccountIdentifier? Accountidentifier { get; init; }

    /// <summary>
    /// The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resourceidentifier")]
    public ResourceIdentifier? Resourceidentifier { get; init; }

    /// <summary>
    /// List of the field names and values to set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("configuration")]
    public ConfigurationModel? Configuration { get; init; }
}
