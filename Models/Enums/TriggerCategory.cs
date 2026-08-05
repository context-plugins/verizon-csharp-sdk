using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The type of trigger being created or modified
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TriggerCategory>))]
public sealed record TriggerCategory : StringEnum<TriggerCategory>
{
    private TriggerCategory(string value) : base(value)
    {
    }

    public static readonly TriggerCategory AccountUsage = new("AccountUsage");

    public static readonly TriggerCategory DeviceGroupUsage = new("DeviceGroupUsage");

    public static readonly TriggerCategory PricePlanDataUsage = new("PricePlanDataUsage");

    public static TriggerCategory FromValue(string value) => FromValueCore(value);
}
