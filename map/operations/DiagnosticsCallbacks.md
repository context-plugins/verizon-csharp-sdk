<!-- Generated file — do not edit; regenerated with the SDK. -->

# DiagnosticsCallbacks — operations

Accessor: `client.DiagnosticsCallbacks` · Source: `Api/DiagnosticsCallbacks.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDiagnosticsSubscriptionCallbackInfo

- **Server group**: `DeviceDiagnostics`
- **Signature**: `GetDiagnosticsSubscriptionCallbackInfo(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `accountName` ← `accountName`
- **Returns**: `IReadOnlyList<DeviceDiagnosticsCallback>`
- **Error**: `SdkException<GetDiagnosticsSubscriptionCallbackInfoError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceDiagnosticsResult(out DeviceDiagnosticsResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceDiagnosticsCallback` | `Models/DeviceDiagnosticsCallback.cs` |
| `GetDiagnosticsSubscriptionCallbackInfoError` | `Errors/GetDiagnosticsSubscriptionCallbackInfoError.cs` |
| `DeviceDiagnosticsResult` | `Models/DeviceDiagnosticsResult.cs` |

### RegisterDiagnosticsCallbackUrl

- **Server group**: `DeviceDiagnostics`
- **Signature**: `RegisterDiagnosticsCallbackUrl(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceDiagnosticsCallback`
- **Error**: `SdkException<RegisterDiagnosticsCallbackUrlError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceDiagnosticsResult(out DeviceDiagnosticsResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceDiagnosticsCallback` | `Models/DeviceDiagnosticsCallback.cs` |
| `RegisterDiagnosticsCallbackUrlError` | `Errors/RegisterDiagnosticsCallbackUrlError.cs` |
| `DeviceDiagnosticsResult` | `Models/DeviceDiagnosticsResult.cs` |

### UnregisterDiagnosticsCallback

- **Server group**: `DeviceDiagnostics`
- **Signature**: `UnregisterDiagnosticsCallback(string accountName, string serviceName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `accountName` ← `accountName`, `serviceName` ← `serviceName`
- **Returns**: `DeviceDiagnosticsCallback`
- **Error**: `SdkException<UnregisterDiagnosticsCallbackError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceDiagnosticsResult(out DeviceDiagnosticsResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceDiagnosticsCallback` | `Models/DeviceDiagnosticsCallback.cs` |
| `UnregisterDiagnosticsCallbackError` | `Errors/UnregisterDiagnosticsCallbackError.cs` |
| `DeviceDiagnosticsResult` | `Models/DeviceDiagnosticsResult.cs` |

