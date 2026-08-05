using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoNotificationGroupRequestEntity
{
    /// <summary>
    /// a short description
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Contact email for the group
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupemail")]
    public string? Groupemail { get; init; }

    /// <summary>
    /// User defined name of the record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
