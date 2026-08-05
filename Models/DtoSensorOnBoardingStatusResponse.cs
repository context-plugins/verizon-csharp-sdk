using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoSensorOnBoardingStatusResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("events")]
    [MaxLength(100)]
    public IReadOnlyList<DtoSensorBoardingEvent>? Events { get; init; }
}
