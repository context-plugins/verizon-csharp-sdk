using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record CallbackRegistrationResult
{
    /// <summary>
    /// The name of the account that registered the callback URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public string? Account { get; init; }

    /// <summary>
    /// The name of the callback service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public CallbackServiceName? Name { get; init; }
}
