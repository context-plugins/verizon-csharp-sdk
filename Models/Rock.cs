using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Indicates the surface of the roadway is rock.
/// </summary>
public record Rock
{
    /// <summary>
    /// Indicates the type of rock.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type11? Type { get; init; }
}
