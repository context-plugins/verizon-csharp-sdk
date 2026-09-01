<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsUsers — operations

Accessor: `client.SensorInsightsUsers` · Source: `Api/SensorInsightsUsers.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsCreateUserRequest

- **Signature**: `SensorInsightsCreateUserRequest(DtoCreateUserRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ResourceUser`
- **Error**: `SdkException<SensorInsightsCreateUserRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoCreateUserRequest` | `Models/DtoCreateUserRequest.cs` |
| `ResourceUser` | `Models/ResourceUser.cs` |
| `SensorInsightsCreateUserRequestError` | `Errors/SensorInsightsCreateUserRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsDeleteUser

- **Signature**: `SensorInsightsDeleteUser(DtoDeleteUserRequest deleterequestpayload, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `deleterequestpayload` ← `deleterequestpayload`
- **Returns**: `void` (Task)
- **Error**: `SdkException<SensorInsightsDeleteUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoDeleteUserRequest` | `Models/DtoDeleteUserRequest.cs` |
| `SensorInsightsDeleteUserError` | `Errors/SensorInsightsDeleteUserError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |

### SensorInsightsListUserRequest

- **Signature**: `SensorInsightsListUserRequest(DtoListUserRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<ResourceUser>`
- **Error**: `SdkException<SensorInsightsListUserRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoListUserRequest` | `Models/DtoListUserRequest.cs` |
| `ResourceUser` | `Models/ResourceUser.cs` |
| `SensorInsightsListUserRequestError` | `Errors/SensorInsightsListUserRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsUpdateUserRequest

- **Signature**: `SensorInsightsUpdateUserRequest(DtoUpdateUserRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ResourceUser`
- **Error**: `SdkException<SensorInsightsUpdateUserRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoUpdateUserRequest` | `Models/DtoUpdateUserRequest.cs` |
| `ResourceUser` | `Models/ResourceUser.cs` |
| `SensorInsightsUpdateUserRequestError` | `Errors/SensorInsightsUpdateUserRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

