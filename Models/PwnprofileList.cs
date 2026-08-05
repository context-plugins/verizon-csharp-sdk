using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record PwnprofileList
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profiles")]
    public IReadOnlyList<Pwnprofile>? Profiles { get; init; }
}
