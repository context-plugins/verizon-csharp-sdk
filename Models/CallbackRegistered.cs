using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Callback listener is Registered.
/// </summary>
public record CallbackRegistered
{
    /// <summary>
    /// The numeric name of the account and must include leading zeroes.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
