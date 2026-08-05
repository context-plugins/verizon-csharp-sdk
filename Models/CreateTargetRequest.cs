using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Details of the target that you want to create.
/// </summary>
public record CreateTargetRequest
{
    /// <summary>
    /// The ID of the authenticating billing account, in the format <c>{"billingaccountid":"1234567890-12345"}</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountidentifier")]
    public AccountIdentifier? Accountidentifier { get; init; }

    /// <summary>
    /// The ID of the authenticating billing account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingaccountid")]
    public string? Billingaccountid { get; init; }

    /// <summary>
    /// Identifies the resource kind. Targets are ts.target.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kind")]
    public string? Kind { get; init; }

    /// <summary>
    /// The endpoint for notifications or data streams. The format depends on the selected <c>addressscheme</c>.&lt;br /&gt;<c>streamrest</c> requires a <c>host:port</c> value &lt;br /&gt;<c>streamawsiot</c> requres a valid ARN.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public string? Address { get; init; }

    /// <summary>
    /// The transport format. Valid values are: &lt;br /&gt;streamawsiot - streamed data to an AWS account &lt;br /&gt;streamrest - streamed REST data to a defined endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addressscheme")]
    public string? Addressscheme { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fields")]
    public CreateTargetRequestFields? Fields { get; init; }

    /// <summary>
    /// Descriptive information about the target.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Security identification string created by a POST /targets/actions/newextid request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("externalid")]
    public string? Externalid { get; init; }

    /// <summary>
    /// Name of the target.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// AWS region value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("region")]
    public string? Region { get; init; }

    /// <summary>
    /// OAuth 2.0 bearer token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key1")]
    public string? Key1 { get; init; }

    /// <summary>
    /// OAuth 2 token and refresh token for TS to stream events to Target.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oauth")]
    public TargetAuthentication? Oauth { get; init; }
}
