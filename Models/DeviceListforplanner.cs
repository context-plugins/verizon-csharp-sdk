using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DeviceListforplanner
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceIds")]
    public IReadOnlyList<DeviceIdforplanner?>? DeviceIds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("privateNetworkApns")]
    public IReadOnlyList<PrivateNetworkApns?>? PrivateNetworkApns { get; init; }

    /// <summary>
    /// A IPv4 address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; init; }

    /// <summary>
    /// The activation code value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activationCode")]
    public string? ActivationCode { get; init; }
}
