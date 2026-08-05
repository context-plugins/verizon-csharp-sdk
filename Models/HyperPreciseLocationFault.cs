using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Fault occurred while responding.
/// </summary>
public record HyperPreciseLocationFault
{
    /// <summary>
    /// Hyper precise location fault code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// Hyper precise location fault message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    /// <summary>
    /// Hyper precise location fault description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }
}
