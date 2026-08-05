using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoConfigurationProfileDelete
{
    /// <summary>
    /// The numeric account name, which must include leading zeros
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resourceidentifier")]
    public DtoResourceidentifier? Resourceidentifier { get; init; }
}
