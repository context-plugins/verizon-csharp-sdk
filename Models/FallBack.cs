using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record FallBack
{
    /// <summary>
    /// An array containing the <c>deviceId</c> array.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devices")]
    [MaxLength(100)]
    public IReadOnlyList<IReadOnlyList<Device>>? Devices { get; init; }

    /// <summary>
    /// The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9]{3,32}$")]
    public string? AccountName { get; init; }
}
