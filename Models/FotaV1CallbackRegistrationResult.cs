using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Registered callback account name and service name.
/// </summary>
public record FotaV1CallbackRegistrationResult
{
    /// <summary>
    /// The name of the billing account for which callback messages will be sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. This will be 'Fota' for the Software Management Services callback.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; init; }
}
