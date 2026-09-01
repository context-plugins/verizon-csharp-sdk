<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementReportsV2 — operations

Accessor: `client.SoftwareManagementReportsV2` · Source: `Api/SoftwareManagementReportsV2.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCampaignDeviceStatus

- **Server group**: `SoftwareManagementV2`
- **Signature**: `GetCampaignDeviceStatus(string account, string campaignId, string? lastSeenDeviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `lastSeenDeviceId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `lastSeenDeviceId` ← `lastSeenDeviceId`
- **Returns**: `V2CampaignDevice`
- **Error**: `SdkException<GetCampaignDeviceStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V2CampaignDevice` | `Models/V2CampaignDevice.cs` |
| `GetCampaignDeviceStatusError` | `Errors/GetCampaignDeviceStatusError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### GetCampaignHistoryByStatus

- **Server group**: `SoftwareManagementV2`
- **Signature**: `GetCampaignHistoryByStatus(string account, string campaignStatus, string? lastSeenCampaignId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `lastSeenCampaignId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `campaignStatus` ← `campaignStatus`, `lastSeenCampaignId` ← `lastSeenCampaignId`
- **Returns**: `V2CampaignHistory`
- **Error**: `SdkException<GetCampaignHistoryByStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V2CampaignHistory` | `Models/V2CampaignHistory.cs` |
| `GetCampaignHistoryByStatusError` | `Errors/GetCampaignHistoryByStatusError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### GetDeviceFirmwareUpgradeHistory2

- **Server group**: `SoftwareManagementV2`
- **Signature**: `GetDeviceFirmwareUpgradeHistory2(string account, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DeviceSoftwareUpgrade>`
- **Error**: `SdkException<GetDeviceFirmwareUpgradeHistory2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceSoftwareUpgrade` | `Models/DeviceSoftwareUpgrade.cs` |
| `GetDeviceFirmwareUpgradeHistory2Error` | `Errors/GetDeviceFirmwareUpgradeHistory2Error.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### ListAccountDevices2

- **Server group**: `SoftwareManagementV2`
- **Signature**: `ListAccountDevices2(string account, string? lastSeenDeviceId, string? distributionType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `lastSeenDeviceId` — nullable, no default → **must pass explicitly**
  - `distributionType` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `lastSeenDeviceId` ← `lastSeenDeviceId`, `distributionType` ← `distributionType`
- **Returns**: `V2AccountDeviceList`
- **Error**: `SdkException<ListAccountDevices2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V2AccountDeviceList` | `Models/V2AccountDeviceList.cs` |
| `ListAccountDevices2Error` | `Errors/ListAccountDevices2Error.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### ListAvailableSoftware

- **Server group**: `SoftwareManagementV2`
- **Signature**: `ListAvailableSoftware(string account, string? distributionType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `distributionType` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `distributionType` ← `distributionType`
- **Returns**: `IReadOnlyList<SoftwarePackage>`
- **Error**: `SdkException<ListAvailableSoftwareError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SoftwarePackage` | `Models/SoftwarePackage.cs` |
| `ListAvailableSoftwareError` | `Errors/ListAvailableSoftwareError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

