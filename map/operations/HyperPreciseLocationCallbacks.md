<!-- Generated file — do not edit; regenerated with the SDK. -->

# HyperPreciseLocationCallbacks — operations

Accessor: `client.HyperPreciseLocationCallbacks` · Source: `Api/HyperPreciseLocationCallbacks.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeregisterCallback6

- **Server group**: `HyperPreciseLocation`
- **Signature**: `DeregisterCallback6(string accountNumber, string service, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `accountNumber` ← `accountNumber`, `service` ← `service`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeregisterCallback6Error>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeregisterCallback6Error` | `Errors/DeregisterCallback6Error.cs` |
| `HyperPreciseLocationResult` | `Models/HyperPreciseLocationResult.cs` |

### ListRegisteredCallbacks6

- **Server group**: `HyperPreciseLocation`
- **Signature**: `ListRegisteredCallbacks6(string accountNumber, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `accountNumber` ← `accountNumber`
- **Returns**: `IReadOnlyList<CallbackCreated>`
- **Error**: `SdkException<ListRegisteredCallbacks6Error>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CallbackCreated` | `Models/CallbackCreated.cs` |
| `ListRegisteredCallbacks6Error` | `Errors/ListRegisteredCallbacks6Error.cs` |
| `HyperPreciseLocationResult` | `Models/HyperPreciseLocationResult.cs` |

### RegisterCallback6

- **Server group**: `HyperPreciseLocation`
- **Signature**: `RegisterCallback6(string accountNumber, HyperPreciseLocationCallback body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `accountNumber` ← `accountNumber`
- **Returns**: `CallbackRegistered`
- **Error**: `SdkException<RegisterCallback6Error>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `HyperPreciseLocationCallback` | `Models/HyperPreciseLocationCallback.cs` |
| `CallbackRegistered` | `Models/CallbackRegistered.cs` |
| `RegisterCallback6Error` | `Errors/RegisterCallback6Error.cs` |
| `HyperPreciseLocationResult` | `Models/HyperPreciseLocationResult.cs` |

