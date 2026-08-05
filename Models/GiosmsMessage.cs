using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GiosmsMessage
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceIds")]
    [MaxLength(100)]
    public IReadOnlyList<GiodeviceId>? DeviceIds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    [StringLength(120, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9 ]{3,120}$")]
    public string? Message { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; init; }
}
