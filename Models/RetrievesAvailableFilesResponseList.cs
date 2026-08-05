using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record RetrievesAvailableFilesResponseList
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AvailableFilesResponse")]
    [MaxLength(100)]
    public IReadOnlyList<RetrievesAvailableFilesResponse>? AvailableFilesResponse { get; init; }
}
