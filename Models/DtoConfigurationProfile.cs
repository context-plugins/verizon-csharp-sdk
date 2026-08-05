using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoConfigurationProfile
{
    /// <summary>
    /// The numeric account name, which must include leading zeros
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountname")]
    public string? Accountname { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profiles")]
    public IReadOnlyList<DtoProfile>? Profiles { get; init; }
}
