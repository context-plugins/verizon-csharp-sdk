<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementCallbacksV2 — operations

Accessor: `client.SoftwareManagementCallbacksV2` · Source: `Api/SoftwareManagementCallbacksV2.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeregisterCallback4

- **Server group**: `SoftwareManagementV2`
- **Signature**: `DeregisterCallback4(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FotaV2SuccessResult`
- **Error**: `SdkException<DeregisterCallback4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FotaV2SuccessResult` | `Models/FotaV2SuccessResult.cs` |
| `DeregisterCallback4Error` | `Errors/DeregisterCallback4Error.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### ListRegisteredCallbacks4

- **Server group**: `SoftwareManagementV2`
- **Signature**: `ListRegisteredCallbacks4(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CallbackSummary`
- **Error**: `SdkException<ListRegisteredCallbacks4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CallbackSummary` | `Models/CallbackSummary.cs` |
| `ListRegisteredCallbacks4Error` | `Errors/ListRegisteredCallbacks4Error.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### RegisterCallback4

- **Server group**: `SoftwareManagementV2`
- **Signature**: `RegisterCallback4(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FotaV2CallbackRegistrationResult`
- **Error**: `SdkException<RegisterCallback4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FotaV2CallbackRegistrationResult` | `Models/FotaV2CallbackRegistrationResult.cs` |
| `RegisterCallback4Error` | `Errors/RegisterCallback4Error.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### UpdateCallback

- **Server group**: `SoftwareManagementV2`
- **Signature**: `UpdateCallback(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FotaV2CallbackRegistrationResult`
- **Error**: `SdkException<UpdateCallbackError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FotaV2CallbackRegistrationResult` | `Models/FotaV2CallbackRegistrationResult.cs` |
| `UpdateCallbackError` | `Errors/UpdateCallbackError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

