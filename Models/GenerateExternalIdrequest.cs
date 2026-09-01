using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Authenticating account ID.
/// </summary>
public record GenerateExternalIdRequest
{
    /// <summary>
    /// The ID of the authenticating billing account, in the format <c>{"billingaccountid":"1234567890-12345"}</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountidentifier")]
    public AccountIdentifier? Accountidentifier { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
