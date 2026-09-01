<!-- Generated file — do not edit; regenerated with the SDK. -->

# DiagnosticsObservations — operations

Accessor: `client.DiagnosticsObservations` · Source: `Api/DiagnosticsObservations.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### StartDiagnosticsObservation

- **Server group**: `DeviceDiagnostics`
- **Signature**: `StartDiagnosticsObservation(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DiagnosticsObservationResult`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DiagnosticsObservationResult` | `Models/DiagnosticsObservationResult.cs` |

### StopDiagnosticsObservation

- **Server group**: `DeviceDiagnostics`
- **Signature**: `StopDiagnosticsObservation(string transactionId, string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `transactionId` ← `transactionId`, `accountName` ← `accountName`
- **Returns**: `DiagnosticsObservationResult`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DiagnosticsObservationResult` | `Models/DiagnosticsObservationResult.cs` |

