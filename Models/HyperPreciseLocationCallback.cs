using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Callback registration request.
/// </summary>
public record HyperPreciseLocationCallback
{
    /// <summary>
    /// The name of the callback service that you want to subscribe to.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The address on your server where you have enabled a listening service for the specific type of callback messages. Specify a URL that is reachable from the Verizon data centers. If your service is running on HTTPS, you should use a one-way authentication certificate with a white-listed IP address.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
