<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceGroups — operations

Accessor: `client.DeviceGroups` · Source: `Api/DeviceGroups.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateDeviceGroup

- **Signature**: `CreateDeviceGroup(CreateDeviceGroupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ConnectivityManagementSuccessResult`
- **Error**: `SdkException<CreateDeviceGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateDeviceGroupRequest` | `Models/CreateDeviceGroupRequest.cs` |
| `ConnectivityManagementSuccessResult` | `Models/ConnectivityManagementSuccessResult.cs` |
| `CreateDeviceGroupError` | `Errors/CreateDeviceGroupError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### DeleteDeviceGroup

- **Signature**: `DeleteDeviceGroup(string aname, string gname, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ConnectivityManagementSuccessResult`
- **Error**: `SdkException<DeleteDeviceGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ConnectivityManagementSuccessResult` | `Models/ConnectivityManagementSuccessResult.cs` |
| `DeleteDeviceGroupError` | `Errors/DeleteDeviceGroupError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### GetDeviceGroupInformation

- **Signature**: `GetDeviceGroupInformation(string aname, string gname, long? next, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `next` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `next` ← `next`
- **Returns**: `DeviceGroupDevicesData`
- **Error**: `SdkException<GetDeviceGroupInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceGroupDevicesData` | `Models/DeviceGroupDevicesData.cs` |
| `GetDeviceGroupInformationError` | `Errors/GetDeviceGroupInformationError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### ListDeviceGroups

- **Signature**: `ListDeviceGroups(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DeviceGroup>`
- **Error**: `SdkException<ListDeviceGroupsError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceGroup` | `Models/DeviceGroup.cs` |
| `ListDeviceGroupsError` | `Errors/ListDeviceGroupsError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### UpdateDeviceGroup

- **Signature**: `UpdateDeviceGroup(string aname, string gname, DeviceGroupUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ConnectivityManagementSuccessResult`
- **Error**: `SdkException<UpdateDeviceGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceGroupUpdateRequest` | `Models/DeviceGroupUpdateRequest.cs` |
| `ConnectivityManagementSuccessResult` | `Models/ConnectivityManagementSuccessResult.cs` |
| `UpdateDeviceGroupError` | `Errors/UpdateDeviceGroupError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

