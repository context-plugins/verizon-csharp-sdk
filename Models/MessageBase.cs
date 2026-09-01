using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.AnyOf;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record MessageBase
{
    /// <summary>
    /// Defines whether the message is private or public.
    /// Private messages are published under the Vendor ID defined in the configuration and only visible to devices of selected vendors.
    /// Public messages are published under the Public vendor and are visible to all the users.
    /// </summary>
    [JsonPropertyName("isPrivate")]
    public required bool IsPrivate { get; init; }

    /// <summary>
    /// Type of the Road User.
    /// </summary>
    [JsonPropertyName("roadUserType")]
    [MinLength(1)]
    [MaxLength(2)]
    public required IReadOnlyList<RoadUserTypes> RoadUserType { get; init; }

    /// <summary>
    /// Trigger conditions that define on which road user action the message will be sent. If multiple Trigger Conditions are defined any of them will trigger the message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerConditions")]
    [MinLength(1)]
    [MaxLength(3)]
    public IReadOnlyList<TriggerCondition>? TriggerConditions { get; init; }

    /// <summary>
    /// List of limitations. These limitations can be used for making the trigger condition more precise by defining speed and motion direction requirements to be met before the messages are sent out.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limits")]
    [MinLength(1)]
    [MaxLength(2)]
    public IReadOnlyList<Limit>? Limits { get; init; }

    /// <summary>
    /// Type of the distribution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distributionType")]
    [MinLength(1)]
    [MaxLength(2)]
    public IReadOnlyList<DistributionTypes>? DistributionType { get; init; }

    /// <summary>
    /// The distribution schedule parameters for broadcast messages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distributionSchedule")]
    public DistributionSchedule? DistributionSchedule { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
