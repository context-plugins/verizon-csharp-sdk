using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// The access rule (DeviceRole object) defines the topics the application or device can publish or subscribe to. It also defines how many parallel subscriptions one device or application can have and how fast it can publish messages.
/// </summary>
public record DeviceRole
{
    /// <summary>
    /// The unique name of the access rule.
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(1000, MinimumLength = 1)]
    [RegularExpression("^[a-zA-Z0-9_$\\{\\}:.-]+$")]
    public required string Name { get; init; }

    /// <summary>
    /// The maximum number of subscriptions that one application or device can make.
    /// </summary>
    [JsonPropertyName("subscribeLimit")]
    [Minimum(0)]
    [Maximum(2147483647)]
    public int? SubscribeLimit { get; init; } = 50;

    /// <summary>
    /// The maximum rate that one application or device can publish messages per seconds.
    /// </summary>
    [JsonPropertyName("publishRateLimit")]
    [Minimum(0)]
    [Maximum(2147483647)]
    public int? PublishRateLimit { get; init; } = 15;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("publish")]
    [MinLength(0)]
    [MaxLength(1000)]
    [UniqueItems]
    public IReadOnlyList<string>? Publish { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscribe")]
    [MinLength(0)]
    [MaxLength(1000)]
    [UniqueItems]
    public IReadOnlyList<string>? Subscribe { get; init; }
}
