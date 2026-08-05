using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Accountid
{
    /// <summary>
    /// The numeric name of the account and must include leading zeroes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mtasAccountNumber")]
    public string? MtasAccountNumber { get; init; }
}
