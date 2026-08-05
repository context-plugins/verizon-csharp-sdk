using System.Text.Json.Serialization;
using Verizon.Core.Validation;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Callback endpoint information.
/// </summary>
public record FotaV1CallbackRegistrationRequest
{
    /// <summary>
    /// The name of the callback service that you want to subscribe to, which must be 'Fota' for Software Management Services callbacks.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The address on your server where you have enabled a listening service for Software Management Services callback messages.
    /// </summary>
    [JsonPropertyName("url")]
    [Format(FormatKind.Uri)]
    public required string Url { get; init; }

    /// <summary>
    /// The user name that ThingSpace should return in the callback messages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("username")]
    public string? Username { get; init; }

    /// <summary>
    /// The password that ThingSpace should return in the callback messages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    public string? Password { get; init; }
}
