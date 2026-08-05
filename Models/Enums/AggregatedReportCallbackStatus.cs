using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// QUEUED or COMPLETED. Requests for IoT devices with cacheMode=0 (cached) have status=COMPLETED; all other requests are QUEUED.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AggregatedReportCallbackStatus>))]
public sealed record AggregatedReportCallbackStatus : StringEnum<AggregatedReportCallbackStatus>
{
    private AggregatedReportCallbackStatus(string value) : base(value)
    {
    }

    public static readonly AggregatedReportCallbackStatus Queued = new("QUEUED");

    public static readonly AggregatedReportCallbackStatus Completed = new("COMPLETED");

    public static AggregatedReportCallbackStatus FromValue(string value) => FromValueCore(value);
}
