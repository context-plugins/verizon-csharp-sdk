<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceLocationCallbacks — operations

Accessor: `client.DeviceLocationCallbacks` · Source: `Api/DeviceLocationCallbacks.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelAsyncReport

- **Server group**: `DeviceLocation`
- **Signature**: `CancelAsyncReport(string txid, string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `accountName` ← `accountName`
- **Returns**: `TransactionId`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionId` | `Models/TransactionId.cs` |

### DeregisterCallback2

- **Server group**: `DeviceLocation`
- **Signature**: `DeregisterCallback2(string accountName, CallbackServiceName service, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceLocationSuccessResult`
- **Error**: `SdkException<DeregisterCallback2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CallbackServiceName` | `Models/Enums/CallbackServiceName.cs` |
| `DeviceLocationSuccessResult` | `Models/DeviceLocationSuccessResult.cs` |
| `DeregisterCallback2Error` | `Errors/DeregisterCallback2Error.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

### ListRegisteredCallbacks2

- **Server group**: `DeviceLocation`
- **Signature**: `ListRegisteredCallbacks2(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DeviceLocationCallback>`
- **Error**: `SdkException<ListRegisteredCallbacks2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceLocationCallback` | `Models/DeviceLocationCallback.cs` |
| `ListRegisteredCallbacks2Error` | `Errors/ListRegisteredCallbacks2Error.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

### RegisterCallback2

- **Server group**: `DeviceLocation`
- **Signature**: `RegisterCallback2(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CallbackRegistrationResult`
- **Error**: `SdkException<RegisterCallback2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CallbackRegistrationResult` | `Models/CallbackRegistrationResult.cs` |
| `RegisterCallback2Error` | `Errors/RegisterCallback2Error.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

