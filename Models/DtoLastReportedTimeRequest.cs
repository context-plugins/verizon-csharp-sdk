using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoLastReportedTimeRequest
{
    /// <summary>
    /// The numeric account name, which must include leading zeros
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountname")]
    public string? Accountname { get; init; }

    /// <summary>
    /// Device identifiers, one or more are required
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resourceidentifier")]
    public DtoDeviceResourceIdentifier? Resourceidentifier { get; init; }
}
