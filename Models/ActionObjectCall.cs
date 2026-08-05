using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ActionObjectCall
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public Actionobject? Action { get; init; }
}
