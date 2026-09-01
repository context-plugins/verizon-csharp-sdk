<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceReports — operations

Accessor: `client.DeviceReports` · Source: `Api/DeviceReports.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CalculateAggregatedReportAsynchronous

- **Server group**: `HyperPreciseLocation`
- **Signature**: `CalculateAggregatedReportAsynchronous(AggregateSessionReportRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AggregatedReportCallbackResult`
- **Error**: `SdkException<CalculateAggregatedReportAsynchronousError>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AggregateSessionReportRequest` | `Models/AggregateSessionReportRequest.cs` |
| `AggregatedReportCallbackResult` | `Models/AggregatedReportCallbackResult.cs` |
| `CalculateAggregatedReportAsynchronousError` | `Errors/CalculateAggregatedReportAsynchronousError.cs` |
| `HyperPreciseLocationResult` | `Models/HyperPreciseLocationResult.cs` |

### CalculateAggregatedReportSynchronous

- **Server group**: `HyperPreciseLocation`
- **Signature**: `CalculateAggregatedReportSynchronous(AggregateSessionReportRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AggregateSessionReport`
- **Error**: `SdkException<CalculateAggregatedReportSynchronousError>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AggregateSessionReportRequest` | `Models/AggregateSessionReportRequest.cs` |
| `AggregateSessionReport` | `Models/AggregateSessionReport.cs` |
| `CalculateAggregatedReportSynchronousError` | `Errors/CalculateAggregatedReportSynchronousError.cs` |
| `HyperPreciseLocationResult` | `Models/HyperPreciseLocationResult.cs` |

### GetSessionsReport

- **Server group**: `HyperPreciseLocation`
- **Signature**: `GetSessionsReport(SessionReportRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SessionReport`
- **Error**: `SdkException<GetSessionsReportError>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SessionReportRequest` | `Models/SessionReportRequest.cs` |
| `SessionReport` | `Models/SessionReport.cs` |
| `GetSessionsReportError` | `Errors/GetSessionsReportError.cs` |
| `HyperPreciseLocationResult` | `Models/HyperPreciseLocationResult.cs` |

