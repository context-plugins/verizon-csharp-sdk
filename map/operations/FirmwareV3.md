<!-- Generated file — do not edit; regenerated with the SDK. -->

# FirmwareV3 — operations

Accessor: `client.FirmwareV3` · Source: `Api/FirmwareV3.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListAvailableFirmware2

- **Server group**: `SoftwareManagementV3`
- **Signature**: `ListAvailableFirmware2(string acc, FirmwareProtocol protocol, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `protocol` ← `protocol`
- **Returns**: `IReadOnlyList<FirmwarePackage>`
- **Error**: `SdkException<ListAvailableFirmware2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FirmwareProtocol` | `Models/Enums/FirmwareProtocol.cs` |
| `FirmwarePackage` | `Models/FirmwarePackage.cs` |
| `ListAvailableFirmware2Error` | `Errors/ListAvailableFirmware2Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

### ReportDeviceFirmware

- **Server group**: `SoftwareManagementV3`
- **Signature**: `ReportDeviceFirmware(string acc, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceFirmwareVersionUpdateResult`
- **Error**: `SdkException<ReportDeviceFirmwareError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceFirmwareVersionUpdateResult` | `Models/DeviceFirmwareVersionUpdateResult.cs` |
| `ReportDeviceFirmwareError` | `Errors/ReportDeviceFirmwareError.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

### SynchronizeDeviceFirmware

- **Server group**: `SoftwareManagementV3`
- **Signature**: `SynchronizeDeviceFirmware(string acc, FirmwareImei body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceFirmwareList`
- **Error**: `SdkException<SynchronizeDeviceFirmwareError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FirmwareImei` | `Models/FirmwareImei.cs` |
| `DeviceFirmwareList` | `Models/DeviceFirmwareList.cs` |
| `SynchronizeDeviceFirmwareError` | `Errors/SynchronizeDeviceFirmwareError.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

