<!-- Generated file — do not edit; regenerated with the SDK. -->

# SessionManagement — operations

Accessor: `client.SessionManagement` · Source: `Api/SessionManagement.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### EndConnectivityManagementSession

- **Signature**: `EndConnectivityManagementSession(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `LogOutRequest`
- **Error**: `SdkException<EndConnectivityManagementSessionError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LogOutRequest` | `Models/LogOutRequest.cs` |
| `EndConnectivityManagementSessionError` | `Errors/EndConnectivityManagementSessionError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### ResetConnectivityManagementPassword

- **Signature**: `ResetConnectivityManagementPassword(SessionResetPasswordRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SessionResetPasswordResult`
- **Error**: `SdkException<ResetConnectivityManagementPasswordError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SessionResetPasswordRequest` | `Models/SessionResetPasswordRequest.cs` |
| `SessionResetPasswordResult` | `Models/SessionResetPasswordResult.cs` |
| `ResetConnectivityManagementPasswordError` | `Errors/ResetConnectivityManagementPasswordError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### StartConnectivityManagementSession

- **Signature**: `StartConnectivityManagementSession(LogInRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `LogInResult`
- **Error**: `SdkException<StartConnectivityManagementSessionError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LogInRequest` | `Models/LogInRequest.cs` |
| `LogInResult` | `Models/LogInResult.cs` |
| `StartConnectivityManagementSessionError` | `Errors/StartConnectivityManagementSessionError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

