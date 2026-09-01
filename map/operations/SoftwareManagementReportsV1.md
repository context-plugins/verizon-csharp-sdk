<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementReportsV1 — operations

Accessor: `client.SoftwareManagementReportsV1` · Source: `Api/SoftwareManagementReportsV1.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDeviceFirmwareUpgradeHistory

- **Server group**: `SoftwareManagementV1`
- **Signature**: `GetDeviceFirmwareUpgradeHistory(string account, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DeviceUpgradeHistory>`
- **Error**: `SdkException<GetDeviceFirmwareUpgradeHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceUpgradeHistory` | `Models/DeviceUpgradeHistory.cs` |
| `GetDeviceFirmwareUpgradeHistoryError` | `Errors/GetDeviceFirmwareUpgradeHistoryError.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

### ListAccountDevices

- **Server group**: `SoftwareManagementV1`
- **Signature**: `ListAccountDevices(string account, string startIndex, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceListQueryResult`
- **Error**: `SdkException<ListAccountDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceListQueryResult` | `Models/DeviceListQueryResult.cs` |
| `ListAccountDevicesError` | `Errors/ListAccountDevicesError.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

### ListUpgradesForSpecifiedStatus

- **Server group**: `SoftwareManagementV1`
- **Signature**: `ListUpgradesForSpecifiedStatus(string account, UpgradeStatus upgradeStatus, string startIndex, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpgradeListQueryResult`
- **Error**: `SdkException<ListUpgradesForSpecifiedStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpgradeStatus` | `Models/Enums/UpgradeStatus.cs` |
| `UpgradeListQueryResult` | `Models/UpgradeListQueryResult.cs` |
| `ListUpgradesForSpecifiedStatusError` | `Errors/ListUpgradesForSpecifiedStatusError.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

