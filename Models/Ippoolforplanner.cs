using System.Text.Json.Serialization;

namespace Verizon.Models;

public record IpPoolforplanner
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isDefaultPool")]
    public bool? IsDefaultPool { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("poolName")]
    public string? PoolName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("poolType")]
    public string? PoolType { get; init; }
}
