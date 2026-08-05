using System;
using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Describes an attribute being observed and the frequency with which the attribute is being observed.
/// </summary>
public record AttributeSetting
{
    /// <summary>
    /// Attribute identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public AttributeIdentifier? Name { get; init; }

    /// <summary>
    /// Attribute value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public string? Value { get; init; }

    /// <summary>
    /// Date and time request was created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createdOn")]
    public DateTimeOffset? CreatedOn { get; init; }

    /// <summary>
    /// Is the attribute observable?
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isObservable")]
    public bool? IsObservable { get; init; }

    /// <summary>
    /// Is the attribute being observed?
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isObserving")]
    public bool? IsObserving { get; init; }

    /// <summary>
    /// Describes value and unit of time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frequency")]
    public NumericalData? Frequency { get; init; }
}
