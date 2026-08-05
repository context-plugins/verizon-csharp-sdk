using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// response for /clients/connection
/// </summary>
public record ConnectionResponse
{
    /// <summary>
    /// The full MQTT URL including protocol, host, and port.
    /// </summary>
    [JsonPropertyName("MqttURL")]
    [MaxLength(1024)]
    [RegularExpression("^mqtt:\\/\\/[a-zA-Z0-9\\.\\-_:]+(:[0-9]+)?(\\/[^\\s]*)?$")]
    public required string MqttUrl { get; init; }

    /// <summary>
    /// The hostname of the MQTT broker to connect to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Host")]
    [MaxLength(1024)]
    [RegularExpression("^[a-zA-Z0-9\\.\\-_]+$")]
    public string? Host { get; init; }

    /// <summary>
    /// The port number of the MQTT broker.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Port")]
    [Minimum(1)]
    [Maximum(65535)]
    public int? Port { get; init; }
}
