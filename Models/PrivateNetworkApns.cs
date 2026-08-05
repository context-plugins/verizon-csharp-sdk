using System.Text.Json.Serialization;

namespace Verizon.Models;

public record PrivateNetworkApns
{
    /// <summary>
    /// the Access Point Name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("apnName")]
    public string? ApnName { get; init; }

    /// <summary>
    /// The method used for address assignment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addressAssignmentMethod")]
    public string? AddressAssignmentMethod { get; init; }

    /// <summary>
    /// A IPv4 address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; init; }
}
