using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// IP pool that is available to the account.
/// </summary>
public record Ippool
{
    /// <summary>
    /// The name of the IP pool.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("poolName")]
    public string? PoolName { get; init; }

    /// <summary>
    /// The type of IP pool, such as “Static IP” or “Dynamic IP.”
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("poolType")]
    public string? PoolType { get; init; }

    /// <summary>
    /// True if this is the default IP pool for the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isDefaultPool")]
    public bool? IsDefaultPool { get; init; }
}
