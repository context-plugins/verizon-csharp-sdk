using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The last status of the device's profile as a filter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProfileStatusFilter>))]
public sealed record ProfileStatusFilter : StringEnum<ProfileStatusFilter>
{
    private ProfileStatusFilter(string value) : base(value)
    {
    }

    public static readonly ProfileStatusFilter Enable = new("ENABLE");

    public static readonly ProfileStatusFilter Disable = new("DISABLE");

    public static readonly ProfileStatusFilter DownloadDisable = new("DOWNLOAD_DISABLE");

    public static readonly ProfileStatusFilter DownloadEnable = new("DOWNLOAD_ENABLE");

    public static readonly ProfileStatusFilter NotDownloaded = new("NOT_DOWNLOADED");

    public static readonly ProfileStatusFilter Unknown = new("UNKNOWN");

    public static readonly ProfileStatusFilter Delete = new("DELETE");

    public static ProfileStatusFilter FromValue(string value) => FromValueCore(value);
}
