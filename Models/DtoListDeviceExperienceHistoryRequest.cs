using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoListDeviceExperienceHistoryRequest
{
    /// <summary>
    /// The numeric account name, which must include leading zeros
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountname")]
    public string? Accountname { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public DtoFilter? Filter { get; init; }
}
