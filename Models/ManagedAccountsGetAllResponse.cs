using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ManagedAccountsGetAllResponse
{
    /// <summary>
    /// Account Name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ManagedAccAddedList")]
    public IReadOnlyList<ManagedAccAddedList>? ManagedAccAddedList { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("managedAccProvisionedList")]
    public IReadOnlyList<ManagedAccProvisionedList>? ManagedAccProvisionedList { get; init; }
}
