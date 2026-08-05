using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Status of the report.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReportStatus>))]
public sealed record ReportStatus : StringEnum<ReportStatus>
{
    private ReportStatus(string value) : base(value)
    {
    }

    public static readonly ReportStatus Queued = new("QUEUED");

    public static readonly ReportStatus Inprogress = new("INPROGRESS");

    public static readonly ReportStatus Completed = new("COMPLETED");

    public static ReportStatus FromValue(string value) => FromValueCore(value);
}
