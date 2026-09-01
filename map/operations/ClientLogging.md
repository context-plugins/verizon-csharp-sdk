<!-- Generated file — do not edit; regenerated with the SDK. -->

# ClientLogging — operations

Accessor: `client.ClientLogging` · Source: `Api/ClientLogging.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DisableDeviceLogging

- **Server group**: `SoftwareManagementV2`
- **Signature**: `DisableDeviceLogging(string account, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DisableDeviceLoggingError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DisableDeviceLoggingError` | `Errors/DisableDeviceLoggingError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### DisableLoggingForDevices

- **Server group**: `SoftwareManagementV2`
- **Signature**: `DisableLoggingForDevices(string account, string deviceIds, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `deviceIds` ← `deviceIds`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DisableLoggingForDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DisableLoggingForDevicesError` | `Errors/DisableLoggingForDevicesError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### EnableDeviceLogging

- **Server group**: `SoftwareManagementV2`
- **Signature**: `EnableDeviceLogging(string account, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceLoggingStatus`
- **Error**: `SdkException<EnableDeviceLoggingError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceLoggingStatus` | `Models/DeviceLoggingStatus.cs` |
| `EnableDeviceLoggingError` | `Errors/EnableDeviceLoggingError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### EnableLoggingForDevices

- **Server group**: `SoftwareManagementV2`
- **Signature**: `EnableLoggingForDevices(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DeviceLoggingStatus>`
- **Error**: `SdkException<EnableLoggingForDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceLoggingStatus` | `Models/DeviceLoggingStatus.cs` |
| `EnableLoggingForDevicesError` | `Errors/EnableLoggingForDevicesError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### ListDeviceLogs

- **Server group**: `SoftwareManagementV2`
- **Signature**: `ListDeviceLogs(string account, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DeviceLog>`
- **Error**: `SdkException<ListDeviceLogsError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceLog` | `Models/DeviceLog.cs` |
| `ListDeviceLogsError` | `Errors/ListDeviceLogsError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### ListDevicesWithLoggingEnabled

- **Server group**: `SoftwareManagementV2`
- **Signature**: `ListDevicesWithLoggingEnabled(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DeviceLoggingStatus>`
- **Error**: `SdkException<ListDevicesWithLoggingEnabledError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceLoggingStatus` | `Models/DeviceLoggingStatus.cs` |
| `ListDevicesWithLoggingEnabledError` | `Errors/ListDevicesWithLoggingEnabledError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

