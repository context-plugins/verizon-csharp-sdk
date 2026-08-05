using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GenerateResponseItem
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("imei")]
    public string? Imei { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credential")]
    public GenerateResponseItemCredential? Credential { get; init; }
}
