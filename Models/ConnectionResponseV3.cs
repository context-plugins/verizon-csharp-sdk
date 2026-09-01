using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// response for api/v3/clients/connection
/// </summary>
public record ConnectionResponseV3
{
    /// <summary>
    /// Array of full MQTT URLs including protocol, host, and port for each available MEC.
    /// </summary>
    [JsonPropertyName("MqttURLs")]
    [MinLength(1)]
    [MaxLength(20)]
    public required IReadOnlyList<string> MqttUrLs { get; init; }

    /// <summary>
    /// Array of hostnames corresponding to each MQTT URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Hosts")]
    [MinLength(1)]
    [MaxLength(20)]
    public IReadOnlyList<string>? Hosts { get; init; }

    /// <summary>
    /// Array of port numbers corresponding to each MQTT URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Ports")]
    [MinLength(1)]
    [MaxLength(20)]
    public IReadOnlyList<int>? Ports { get; init; }
}
