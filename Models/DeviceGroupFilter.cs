using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DeviceGroupFilter
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceGroupName")]
    public string? DeviceGroupName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("IndividualOrCombined")]
    public string? IndividualOrCombined { get; init; }

    /// <summary>
    /// The numeric name of the account and must include leading zeroes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
