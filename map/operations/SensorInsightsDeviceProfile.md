<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsDeviceProfile — operations

Accessor: `client.SensorInsightsDeviceProfile` · Source: `Api/SensorInsightsDeviceProfile.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAProfile

- **Signature**: `CreateAProfile(DtoConfigurationProfile body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DtoProfileResponse>`
- **Error**: `SdkException<CreateAProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoConfigurationProfile` | `Models/DtoConfigurationProfile.cs` |
| `DtoProfileResponse` | `Models/DtoProfileResponse.cs` |
| `CreateAProfileError` | `Errors/CreateAProfileError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### DeleteAProfile

- **Signature**: `DeleteAProfile(DtoConfigurationProfileDelete deleterequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DtoProfileResponse>`
- **Error**: `SdkException<DeleteAProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoConfigurationProfileDelete` | `Models/DtoConfigurationProfileDelete.cs` |
| `DtoProfileResponse` | `Models/DtoProfileResponse.cs` |
| `DeleteAProfileError` | `Errors/DeleteAProfileError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### QueryAProfile

- **Signature**: `QueryAProfile(ResourceResourceQuery body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DtoProfileResponse>`
- **Error**: `SdkException<QueryAProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ResourceResourceQuery` | `Models/ResourceResourceQuery.cs` |
| `DtoProfileResponse` | `Models/DtoProfileResponse.cs` |
| `QueryAProfileError` | `Errors/QueryAProfileError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### UpdateAProfile

- **Signature**: `UpdateAProfile(DtoConfigurationProfilePath body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DtoProfileResponse>`
- **Error**: `SdkException<UpdateAProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoConfigurationProfilePath` | `Models/DtoConfigurationProfilePath.cs` |
| `DtoProfileResponse` | `Models/DtoProfileResponse.cs` |
| `UpdateAProfileError` | `Errors/UpdateAProfileError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

