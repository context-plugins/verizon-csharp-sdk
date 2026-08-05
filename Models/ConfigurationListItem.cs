using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The ConfigurationList's item that contains the configuration identifier, name, description and the active flag.
/// </summary>
public record ConfigurationListItem
{
    /// <summary>
    /// The generated ID (UUID v4) for the configuration. It has to be used when asking for changing any of the configuration parameters.
    /// </summary>
    [JsonPropertyName("id")]
    [StringLength(36, MinimumLength = 32)]
    [RegularExpression("^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$")]
    public required string Id { get; init; }

    /// <summary>
    /// Name of the configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [StringLength(256, MinimumLength = 1)]
    [RegularExpression("^[\\w\\+\\-!()\\`\\[\\]{=};\\\"':,.\\/<>?|\\s]+$")]
    public string? Name { get; init; }

    /// <summary>
    /// Description of the configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [StringLength(2048, MinimumLength = 1)]
    [RegularExpression("^[\\w\\+\\-!()\\`\\[\\]{=};\\\"':,.\\/<>?|\\s]+$")]
    public string? Description { get; init; }

    [JsonPropertyName("isActive")]
    public required bool IsActive { get; init; }
}
