using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The status of the upgrades that you want to retrieve.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UpgradeStatus>))]
public sealed record UpgradeStatus : StringEnum<UpgradeStatus>
{
    private UpgradeStatus(string value) : base(value)
    {
    }

    public static readonly UpgradeStatus RequestPending = new("RequestPending");

    public static readonly UpgradeStatus Queued = new("Queued");

    public static readonly UpgradeStatus RequestFailed = new("RequestFailed");

    public static readonly UpgradeStatus InProgress = new("InProgress");

    public static readonly UpgradeStatus Finished = new("Finished");

    public static readonly UpgradeStatus UpgradeFailed = new("UpgradeFailed");

    public static UpgradeStatus FromValue(string value) => FromValueCore(value);
}
