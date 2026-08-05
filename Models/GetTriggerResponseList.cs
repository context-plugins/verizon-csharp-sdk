using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GetTriggerResponseList
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggers")]
    [MaxLength(3)]
    public IReadOnlyList<GetTriggerResponse>? Triggers { get; init; }
}
