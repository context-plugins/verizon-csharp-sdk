using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The last status of the device as a list filter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProvisioningStatusFilter>))]
public sealed record ProvisioningStatusFilter : StringEnum<ProvisioningStatusFilter>
{
    private ProvisioningStatusFilter(string value) : base(value)
    {
    }

    public static readonly ProvisioningStatusFilter Unknown = new("UNKNOWN");

    public static readonly ProvisioningStatusFilter Deactivated = new("DEACTIVATED");

    public static readonly ProvisioningStatusFilter Activated = new("ACTIVATED");

    public static readonly ProvisioningStatusFilter Deactive = new("DEACTIVE");

    public static readonly ProvisioningStatusFilter Active = new("ACTIVE");

    public static readonly ProvisioningStatusFilter Suspend = new("SUSPEND");

    public static readonly ProvisioningStatusFilter PendingActivation = new("PENDING_ACTIVATION");

    public static readonly ProvisioningStatusFilter PendingDeactivation = new("PENDING_DEACTIVATION");

    public static readonly ProvisioningStatusFilter PreActive = new("PRE_ACTIVE");

    public static readonly ProvisioningStatusFilter ActivationReady = new("ACTIVATION_READY");

    public static readonly ProvisioningStatusFilter Inventory = new("INVENTORY");

    public static readonly ProvisioningStatusFilter Purged = new("PURGED");

    public static readonly ProvisioningStatusFilter Replaced = new("REPLACED");

    public static readonly ProvisioningStatusFilter Retired = new("RETIRED");

    public static readonly ProvisioningStatusFilter TestReady = new("TEST_READY");

    public static ProvisioningStatusFilter FromValue(string value) => FromValueCore(value);
}
