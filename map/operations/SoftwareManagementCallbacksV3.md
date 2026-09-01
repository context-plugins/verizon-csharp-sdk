<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementCallbacksV3 — operations

Accessor: `client.SoftwareManagementCallbacksV3` · Source: `Api/SoftwareManagementCallbacksV3.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeregisterCallback5

- **Server group**: `SoftwareManagementV3`
- **Signature**: `DeregisterCallback5(string acc, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FotaV3SuccessResult`
- **Error**: `SdkException<DeregisterCallback5Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FotaV3SuccessResult` | `Models/FotaV3SuccessResult.cs` |
| `DeregisterCallback5Error` | `Errors/DeregisterCallback5Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

### ListRegisteredCallbacks5

- **Server group**: `SoftwareManagementV3`
- **Signature**: `ListRegisteredCallbacks5(string acc, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FotaV3CallbackSummary`
- **Error**: `SdkException<ListRegisteredCallbacks5Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FotaV3CallbackSummary` | `Models/FotaV3CallbackSummary.cs` |
| `ListRegisteredCallbacks5Error` | `Errors/ListRegisteredCallbacks5Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

### RegisterCallback5

- **Server group**: `SoftwareManagementV3`
- **Signature**: `RegisterCallback5(string acc, FotaV3CallbackRegistrationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FotaV3CallbackRegistrationResult`
- **Error**: `SdkException<RegisterCallback5Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FotaV3CallbackRegistrationRequest` | `Models/FotaV3CallbackRegistrationRequest.cs` |
| `FotaV3CallbackRegistrationResult` | `Models/FotaV3CallbackRegistrationResult.cs` |
| `RegisterCallback5Error` | `Errors/RegisterCallback5Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

### UpdateCallback2

- **Server group**: `SoftwareManagementV3`
- **Signature**: `UpdateCallback2(string acc, FotaV3CallbackRegistrationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FotaV3CallbackRegistrationResult`
- **Error**: `SdkException<UpdateCallback2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FotaV3CallbackRegistrationRequest` | `Models/FotaV3CallbackRegistrationRequest.cs` |
| `FotaV3CallbackRegistrationResult` | `Models/FotaV3CallbackRegistrationResult.cs` |
| `UpdateCallback2Error` | `Errors/UpdateCallback2Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

