<!-- Generated file — do not edit; regenerated with the SDK. -->

# EtxAppConfiguration — operations

Accessor: `client.EtxAppConfiguration` · Source: `Api/EtxAppConfiguration.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateConfiguration

- **Server group**: `ImpServer`
- **Signature**: `CreateConfiguration(string vendorId, GeoFenceConfigurationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GeoFenceConfigurationResponse`
- **Error**: `SdkException<CreateConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetResponseError(out ResponseError)` [400, 403, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GeoFenceConfigurationRequest` | `Models/GeoFenceConfigurationRequest.cs` |
| `GeoFenceConfigurationResponse` | `Models/GeoFenceConfigurationResponse.cs` |
| `CreateConfigurationError` | `Errors/CreateConfigurationError.cs` |
| `ResponseError` | `Models/ResponseError.cs` |

### DeleteConfiguration

- **Server group**: `ImpServer`
- **Signature**: `DeleteConfiguration(string id, string vendorId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `id` ← `id`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetResponseError(out ResponseError)` [403, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteConfigurationError` | `Errors/DeleteConfigurationError.cs` |
| `ResponseError` | `Models/ResponseError.cs` |

### GetConfiguration

- **Server group**: `ImpServer`
- **Signature**: `GetConfiguration(string id, string vendorId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `id` ← `id`
- **Returns**: `GeoFenceConfigurationResponse`
- **Error**: `SdkException<GetConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetResponseError(out ResponseError)` [403, 404, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GeoFenceConfigurationResponse` | `Models/GeoFenceConfigurationResponse.cs` |
| `GetConfigurationError` | `Errors/GetConfigurationError.cs` |
| `ResponseError` | `Models/ResponseError.cs` |

### GetConfigurationList

- **Server group**: `ImpServer`
- **Signature**: `GetConfigurationList(string vendorId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<ConfigurationListItem>`
- **Error**: `SdkException<GetConfigurationListError>` — **Case A (typed)**
- **Error accessors**: `TryGetResponseError(out ResponseError)` [403, 404, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ConfigurationListItem` | `Models/ConfigurationListItem.cs` |
| `GetConfigurationListError` | `Errors/GetConfigurationListError.cs` |
| `ResponseError` | `Models/ResponseError.cs` |

### UpdateConfiguration

- **Server group**: `ImpServer`
- **Signature**: `UpdateConfiguration(string id, string vendorId, GeoFenceConfigurationUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `id` ← `id`
- **Returns**: `void` (Task)
- **Error**: `SdkException<UpdateConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetResponseError(out ResponseError)` [400, 403, 404, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GeoFenceConfigurationUpdateRequest` | `Models/GeoFenceConfigurationUpdateRequest.cs` |
| `UpdateConfigurationError` | `Errors/UpdateConfigurationError.cs` |
| `ResponseError` | `Models/ResponseError.cs` |

