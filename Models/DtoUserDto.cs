using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoUserDto
{
    /// <summary>
    /// Contact email for the group
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// The first name in the user record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstname")]
    public string? Firstname { get; init; }

    /// <summary>
    /// The last name in the user record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastname")]
    public string? Lastname { get; init; }

    /// <summary>
    /// The Mobile Directory Number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mdn")]
    public string? Mdn { get; init; }

    /// <summary>
    /// Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customdata")]
    public IReadOnlyDictionary<string, object>? Customdata { get; init; }
}
