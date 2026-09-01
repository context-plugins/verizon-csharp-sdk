<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementReportsV3 — operations

Accessor: `client.SoftwareManagementReportsV3` · Source: `Api/SoftwareManagementReportsV3.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCampaignDeviceStatus2

- **Server group**: `SoftwareManagementV3`
- **Signature**: `GetCampaignDeviceStatus2(string acc, string campaignId, string? lastSeenDeviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `lastSeenDeviceId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `lastSeenDeviceId` ← `lastSeenDeviceId`
- **Returns**: `V3CampaignDevice`
- **Error**: `SdkException<GetCampaignDeviceStatus2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V3CampaignDevice` | `Models/V3CampaignDevice.cs` |
| `GetCampaignDeviceStatus2Error` | `Errors/GetCampaignDeviceStatus2Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

### GetCampaignHistoryByStatus2

- **Server group**: `SoftwareManagementV3`
- **Signature**: `GetCampaignHistoryByStatus2(string acc, CampaignStatus campaignStatus, string? lastSeenCampaignId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `lastSeenCampaignId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `campaignStatus` ← `campaignStatus`, `lastSeenCampaignId` ← `lastSeenCampaignId`
- **Returns**: `V3CampaignHistory`
- **Error**: `SdkException<GetCampaignHistoryByStatus2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CampaignStatus` | `Models/Enums/CampaignStatus.cs` |
| `V3CampaignHistory` | `Models/V3CampaignHistory.cs` |
| `GetCampaignHistoryByStatus2Error` | `Errors/GetCampaignHistoryByStatus2Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

### GetDeviceFirmwareUpgradeHistory3

- **Server group**: `SoftwareManagementV3`
- **Signature**: `GetDeviceFirmwareUpgradeHistory3(string acc, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DeviceFirmwareUpgrade>`
- **Error**: `SdkException<GetDeviceFirmwareUpgradeHistory3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceFirmwareUpgrade` | `Models/DeviceFirmwareUpgrade.cs` |
| `GetDeviceFirmwareUpgradeHistory3Error` | `Errors/GetDeviceFirmwareUpgradeHistory3Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

