using System.Text.Json.Serialization;

namespace Verizon.Models;

public record CallbackCreated
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

    /// <summary>
    /// The address of the callback listening service where the ThingSpace Platform will send callback messages for the service type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
