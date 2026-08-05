using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record DeviceLocationCallback
{
    /// <summary>
    /// The name of the callback service.
    /// </summary>
    [JsonPropertyName("name")]
    public required CallbackServiceName Name { get; init; }

    /// <summary>
    /// The location of your callback listener.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }
}
