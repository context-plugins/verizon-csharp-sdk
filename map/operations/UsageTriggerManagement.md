<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsageTriggerManagement — operations

Accessor: `client.UsageTriggerManagement` · Source: `Api/UsageTriggerManagement.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateNewTrigger

- **Server group**: `SubscriptionServer`
- **Signature**: `CreateNewTrigger(UsageTriggerAddRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `UsageTriggerResponse`
- **Error**: `SdkException<CreateNewTriggerError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsageTriggerAddRequest` | `Models/UsageTriggerAddRequest.cs` |
| `UsageTriggerResponse` | `Models/UsageTriggerResponse.cs` |
| `CreateNewTriggerError` | `Errors/CreateNewTriggerError.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

### DeleteTrigger

- **Server group**: `SubscriptionServer`
- **Signature**: `DeleteTrigger(string accountName, string triggerId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceLocationSuccessResult`
- **Error**: `SdkException<DeleteTriggerError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceLocationSuccessResult` | `Models/DeviceLocationSuccessResult.cs` |
| `DeleteTriggerError` | `Errors/DeleteTriggerError.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

### UpdateTrigger

- **Server group**: `SubscriptionServer`
- **Signature**: `UpdateTrigger(string triggerId, UsageTriggerUpdateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `UsageTriggerResponse`
- **Error**: `SdkException<UpdateTriggerError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsageTriggerUpdateRequest` | `Models/UsageTriggerUpdateRequest.cs` |
| `UsageTriggerResponse` | `Models/UsageTriggerResponse.cs` |
| `UpdateTriggerError` | `Errors/UpdateTriggerError.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

