using System;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoSensorBoardingEvent
{
    /// <summary>
    /// Timestamp of the record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createdon")]
    public DateTimeOffset? Createdon { get; init; }

    /// <summary>
    /// Error message
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; init; }

    /// <summary>
    /// Fields to return needed by search
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fields")]
    public DtoFields? Fields { get; init; }

    /// <summary>
    /// The current status of the device or transaction and will be <c>success</c> or <c>failed</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

    /// <summary>
    /// The system-generated UUID of the transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionid")]
    public string? Transactionid { get; init; }
}
