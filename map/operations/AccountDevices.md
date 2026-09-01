<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountDevices — operations

Accessor: `client.AccountDevices` · Source: `Api/AccountDevices.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountDeviceInformation

- **Server group**: `SoftwareManagementV3`
- **Signature**: `GetAccountDeviceInformation(string acc, string? lastSeenDeviceId, DevicesProtocol? protocol, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `lastSeenDeviceId` — nullable, no default → **must pass explicitly**
  - `protocol` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `lastSeenDeviceId` ← `lastSeenDeviceId`, `protocol` ← `protocol`
- **Returns**: `V3AccountDeviceList`
- **Error**: `SdkException<GetAccountDeviceInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DevicesProtocol` | `Models/Enums/DevicesProtocol.cs` |
| `V3AccountDeviceList` | `Models/V3AccountDeviceList.cs` |
| `GetAccountDeviceInformationError` | `Errors/GetAccountDeviceInformationError.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

### ListAccountDevicesInformation

- **Server group**: `SoftwareManagementV3`
- **Signature**: `ListAccountDevicesInformation(string acc, DeviceImei body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceListResult`
- **Error**: `SdkException<ListAccountDevicesInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceImei` | `Models/DeviceImei.cs` |
| `DeviceListResult` | `Models/DeviceListResult.cs` |
| `ListAccountDevicesInformationError` | `Errors/ListAccountDevicesInformationError.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

