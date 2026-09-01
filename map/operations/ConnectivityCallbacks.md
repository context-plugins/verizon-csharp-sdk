<!-- Generated file — do not edit; regenerated with the SDK. -->

# ConnectivityCallbacks — operations

Accessor: `client.ConnectivityCallbacks` · Source: `Api/ConnectivityCallbacks.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeregisterCallback

- **Signature**: `DeregisterCallback(string aname, string sname, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CallbackActionResult`
- **Error**: `SdkException<DeregisterCallbackError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CallbackActionResult` | `Models/CallbackActionResult.cs` |
| `DeregisterCallbackError` | `Errors/DeregisterCallbackError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### ListRegisteredCallbacks

- **Signature**: `ListRegisteredCallbacks(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<ConnectivityManagementCallback>`
- **Error**: `SdkException<ListRegisteredCallbacksError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ConnectivityManagementCallback` | `Models/ConnectivityManagementCallback.cs` |
| `ListRegisteredCallbacksError` | `Errors/ListRegisteredCallbacksError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### RegisterCallback

- **Signature**: `RegisterCallback(string aname, RegisterCallbackRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CallbackActionResult`
- **Error**: `SdkException<RegisterCallbackError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RegisterCallbackRequest` | `Models/RegisterCallbackRequest.cs` |
| `CallbackActionResult` | `Models/CallbackActionResult.cs` |
| `RegisterCallbackError` | `Errors/RegisterCallbackError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

