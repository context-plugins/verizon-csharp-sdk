using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// An item object wrapping an ITIS code value.
/// </summary>
public record ItisItemContent
{
    /// <summary>
    /// The ITIS Code that describes the alert/danger/hazard. All ITS standards use the same types here to explain the type of the alert/danger/hazard involved.
    /// <para>
    /// The complete set of ITIS codes can be found in Volume Two of the SAE J2540 standard. This is a set of over 1000 items which are used to encode common events and list items in ITS.
    /// </para>
    /// </summary>
    [JsonPropertyName("itis")]
    [Minimum(0)]
    [Maximum(65535)]
    public required int Itis { get; init; }
}
