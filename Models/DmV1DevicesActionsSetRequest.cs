using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DmV1DevicesActionsSetRequest
{
    /// <summary>
    /// The numeric account name, which must include leading zeros
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountname")]
    public string? Accountname { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("configuration")]
    public DtoDeviceActionSetConfiguration1? Configuration { get; init; }

    /// <summary>
    /// Device identifiers, one or more are required
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resourceidentifier")]
    public DtoDeviceResourceIdentifier1? Resourceidentifier { get; init; }
}
