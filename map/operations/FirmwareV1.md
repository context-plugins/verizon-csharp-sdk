<!-- Generated file — do not edit; regenerated with the SDK. -->

# FirmwareV1 — operations

Accessor: `client.FirmwareV1` · Source: `Api/FirmwareV1.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelScheduledFirmwareUpgrade

- **Server group**: `SoftwareManagementV1`
- **Signature**: `CancelScheduledFirmwareUpgrade(string accountName, string upgradeId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FotaV1SuccessResult`
- **Error**: `SdkException<CancelScheduledFirmwareUpgradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FotaV1SuccessResult` | `Models/FotaV1SuccessResult.cs` |
| `CancelScheduledFirmwareUpgradeError` | `Errors/CancelScheduledFirmwareUpgradeError.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

### ListAvailableFirmware

- **Server group**: `SoftwareManagementV1`
- **Signature**: `ListAvailableFirmware(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<Firmware>`
- **Error**: `SdkException<ListAvailableFirmwareError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Firmware` | `Models/Firmware.cs` |
| `ListAvailableFirmwareError` | `Errors/ListAvailableFirmwareError.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

### ListFirmwareUpgradeDetails

- **Server group**: `SoftwareManagementV1`
- **Signature**: `ListFirmwareUpgradeDetails(string accountName, string upgradeId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FirmwareUpgrade`
- **Error**: `SdkException<ListFirmwareUpgradeDetailsError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FirmwareUpgrade` | `Models/FirmwareUpgrade.cs` |
| `ListFirmwareUpgradeDetailsError` | `Errors/ListFirmwareUpgradeDetailsError.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

### ScheduleFirmwareUpgrade

- **Server group**: `SoftwareManagementV1`
- **Signature**: `ScheduleFirmwareUpgrade(FirmwareUpgradeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FirmwareUpgrade`
- **Error**: `SdkException<ScheduleFirmwareUpgradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FirmwareUpgradeRequest` | `Models/FirmwareUpgradeRequest.cs` |
| `FirmwareUpgrade` | `Models/FirmwareUpgrade.cs` |
| `ScheduleFirmwareUpgradeError` | `Errors/ScheduleFirmwareUpgradeError.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

### UpdateFirmwareUpgradeDevices

- **Server group**: `SoftwareManagementV1`
- **Signature**: `UpdateFirmwareUpgradeDevices(string accountName, string upgradeId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FirmwareUpgradeChangeResult`
- **Error**: `SdkException<UpdateFirmwareUpgradeDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FirmwareUpgradeChangeResult` | `Models/FirmwareUpgradeChangeResult.cs` |
| `UpdateFirmwareUpgradeDevicesError` | `Errors/UpdateFirmwareUpgradeDevicesError.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

