<!-- Generated file — do not edit; regenerated with the SDK. -->

# EUiccDeviceProfileManagement — operations

Accessor: `client.EUiccDeviceProfileManagement` · Source: `Api/EUiccDeviceProfileManagement.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteLocalProfile

- **Signature**: `DeleteLocalProfile(ProfileChangeStateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RequestResponse`
- **Error**: `SdkException<DeleteLocalProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ProfileChangeStateRequest` | `Models/ProfileChangeStateRequest.cs` |
| `RequestResponse` | `Models/RequestResponse.cs` |
| `DeleteLocalProfileError` | `Errors/DeleteLocalProfileError.cs` |
| `RestErrorResponse` | `Models/RestErrorResponse.cs` |

### DisableLocalProfile

- **Signature**: `DisableLocalProfile(ProfileChangeStateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RequestResponse`
- **Error**: `SdkException<DisableLocalProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ProfileChangeStateRequest` | `Models/ProfileChangeStateRequest.cs` |
| `RequestResponse` | `Models/RequestResponse.cs` |
| `DisableLocalProfileError` | `Errors/DisableLocalProfileError.cs` |
| `RestErrorResponse` | `Models/RestErrorResponse.cs` |

### DownloadLocalProfileToDisable

- **Signature**: `DownloadLocalProfileToDisable(ProfileChangeStateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<DownloadLocalProfileToDisableError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ProfileChangeStateRequest` | `Models/ProfileChangeStateRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `DownloadLocalProfileToDisableError` | `Errors/DownloadLocalProfileToDisableError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### DownloadLocalProfileToEnable

- **Signature**: `DownloadLocalProfileToEnable(ProfileChangeStateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<DownloadLocalProfileToEnableError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ProfileChangeStateRequest` | `Models/ProfileChangeStateRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `DownloadLocalProfileToEnableError` | `Errors/DownloadLocalProfileToEnableError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### EnableLocalProfile

- **Signature**: `EnableLocalProfile(ProfileChangeStateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RequestResponse`
- **Error**: `SdkException<EnableLocalProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ProfileChangeStateRequest` | `Models/ProfileChangeStateRequest.cs` |
| `RequestResponse` | `Models/RequestResponse.cs` |
| `EnableLocalProfileError` | `Errors/EnableLocalProfileError.cs` |
| `RestErrorResponse` | `Models/RestErrorResponse.cs` |

