<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementCallbacksV1 — operations

Accessor: `client.SoftwareManagementCallbacksV1` · Source: `Api/SoftwareManagementCallbacksV1.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeregisterCallback3

- **Server group**: `SoftwareManagementV1`
- **Signature**: `DeregisterCallback3(string account, CallbackService service, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeregisterCallback3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CallbackService` | `Models/Enums/CallbackService.cs` |
| `DeregisterCallback3Error` | `Errors/DeregisterCallback3Error.cs` |

### ListRegisteredCallbacks3

- **Server group**: `SoftwareManagementV1`
- **Signature**: `ListRegisteredCallbacks3(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<RegisteredCallbacks>`
- **Error**: `SdkException<ListRegisteredCallbacks3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RegisteredCallbacks` | `Models/RegisteredCallbacks.cs` |
| `ListRegisteredCallbacks3Error` | `Errors/ListRegisteredCallbacks3Error.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

### RegisterCallback3

- **Server group**: `SoftwareManagementV1`
- **Signature**: `RegisterCallback3(string account, FotaV1CallbackRegistrationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FotaV1CallbackRegistrationResult`
- **Error**: `SdkException<RegisterCallback3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FotaV1CallbackRegistrationRequest` | `Models/FotaV1CallbackRegistrationRequest.cs` |
| `FotaV1CallbackRegistrationResult` | `Models/FotaV1CallbackRegistrationResult.cs` |
| `RegisterCallback3Error` | `Errors/RegisterCallback3Error.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

