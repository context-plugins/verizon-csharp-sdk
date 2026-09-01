<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsNotificationGroups — operations

Accessor: `client.SensorInsightsNotificationGroups` · Source: `Api/SensorInsightsNotificationGroups.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsAddUsersToNotificationGroupRequest

- **Signature**: `SensorInsightsAddUsersToNotificationGroupRequest(DtoAddUsersToNotificationGroupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<SensorInsightsAddUsersToNotificationGroupRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoAddUsersToNotificationGroupRequest` | `Models/DtoAddUsersToNotificationGroupRequest.cs` |
| `SensorInsightsAddUsersToNotificationGroupRequestError` | `Errors/SensorInsightsAddUsersToNotificationGroupRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsCreateNotificationGroupRequest

- **Signature**: `SensorInsightsCreateNotificationGroupRequest(DtoCreateNotificationGroupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DtoNotificationGroupResponseEntity`
- **Error**: `SdkException<SensorInsightsCreateNotificationGroupRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoCreateNotificationGroupRequest` | `Models/DtoCreateNotificationGroupRequest.cs` |
| `DtoNotificationGroupResponseEntity` | `Models/DtoNotificationGroupResponseEntity.cs` |
| `SensorInsightsCreateNotificationGroupRequestError` | `Errors/SensorInsightsCreateNotificationGroupRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsDeleteNotificationGroup

- **Signature**: `SensorInsightsDeleteNotificationGroup(DtoDeleteNotificationGroupRequest payload, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `payload` ← `payload`
- **Returns**: `void` (Task)
- **Error**: `SdkException<SensorInsightsDeleteNotificationGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoDeleteNotificationGroupRequest` | `Models/DtoDeleteNotificationGroupRequest.cs` |
| `SensorInsightsDeleteNotificationGroupError` | `Errors/SensorInsightsDeleteNotificationGroupError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |

### SensorInsightsListNotificationGroupRequest

- **Signature**: `SensorInsightsListNotificationGroupRequest(DtoListNotificationGroupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DtoNotificationGroupResponseEntity>`
- **Error**: `SdkException<SensorInsightsListNotificationGroupRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoListNotificationGroupRequest` | `Models/DtoListNotificationGroupRequest.cs` |
| `DtoNotificationGroupResponseEntity` | `Models/DtoNotificationGroupResponseEntity.cs` |
| `SensorInsightsListNotificationGroupRequestError` | `Errors/SensorInsightsListNotificationGroupRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsRemoveUsersFromNotificationGroupRequest

- **Signature**: `SensorInsightsRemoveUsersFromNotificationGroupRequest(DtoRemoveUsersFromNotificationGroupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<SensorInsightsRemoveUsersFromNotificationGroupRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoRemoveUsersFromNotificationGroupRequest` | `Models/DtoRemoveUsersFromNotificationGroupRequest.cs` |
| `SensorInsightsRemoveUsersFromNotificationGroupRequestError` | `Errors/SensorInsightsRemoveUsersFromNotificationGroupRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsUpdateNotificationGroupRequest

- **Signature**: `SensorInsightsUpdateNotificationGroupRequest(DtoUpdateNotificationGroupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DtoNotificationGroupResponseEntity`
- **Error**: `SdkException<SensorInsightsUpdateNotificationGroupRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoUpdateNotificationGroupRequest` | `Models/DtoUpdateNotificationGroupRequest.cs` |
| `DtoNotificationGroupResponseEntity` | `Models/DtoNotificationGroupResponseEntity.cs` |
| `SensorInsightsUpdateNotificationGroupRequestError` | `Errors/SensorInsightsUpdateNotificationGroupRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

