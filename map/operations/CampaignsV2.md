<!-- Generated file — do not edit; regenerated with the SDK. -->

# CampaignsV2 — operations

Accessor: `client.CampaignsV2` · Source: `Api/CampaignsV2.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelCampaign

- **Server group**: `SoftwareManagementV2`
- **Signature**: `CancelCampaign(string account, string campaignId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FotaV2SuccessResult`
- **Error**: `SdkException<CancelCampaignError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FotaV2SuccessResult` | `Models/FotaV2SuccessResult.cs` |
| `CancelCampaignError` | `Errors/CancelCampaignError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### GetCampaignInformation

- **Server group**: `SoftwareManagementV2`
- **Signature**: `GetCampaignInformation(string account, string campaignId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CampaignSoftware`
- **Error**: `SdkException<GetCampaignInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CampaignSoftware` | `Models/CampaignSoftware.cs` |
| `GetCampaignInformationError` | `Errors/GetCampaignInformationError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### ScheduleCampaignFirmwareUpgrade

- **Server group**: `SoftwareManagementV2`
- **Signature**: `ScheduleCampaignFirmwareUpgrade(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CampaignSoftware`
- **Error**: `SdkException<ScheduleCampaignFirmwareUpgradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CampaignSoftware` | `Models/CampaignSoftware.cs` |
| `ScheduleCampaignFirmwareUpgradeError` | `Errors/ScheduleCampaignFirmwareUpgradeError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### ScheduleFileUpgrade

- **Server group**: `SoftwareManagementV2`
- **Signature**: `ScheduleFileUpgrade(string acc, UploadAndScheduleFileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UploadAndScheduleFileResponse`
- **Error**: `SdkException<ScheduleFileUpgradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UploadAndScheduleFileRequest` | `Models/UploadAndScheduleFileRequest.cs` |
| `UploadAndScheduleFileResponse` | `Models/UploadAndScheduleFileResponse.cs` |
| `ScheduleFileUpgradeError` | `Errors/ScheduleFileUpgradeError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### ScheduleSwUpgradeHttpDevices

- **Server group**: `SoftwareManagementV2`
- **Signature**: `ScheduleSwUpgradeHttpDevices(string acc, SchedulesSoftwareUpgradeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UploadAndScheduleFileResponse`
- **Error**: `SdkException<ScheduleSwUpgradeHttpDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SchedulesSoftwareUpgradeRequest` | `Models/SchedulesSoftwareUpgradeRequest.cs` |
| `UploadAndScheduleFileResponse` | `Models/UploadAndScheduleFileResponse.cs` |
| `ScheduleSwUpgradeHttpDevicesError` | `Errors/ScheduleSwUpgradeHttpDevicesError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### UpdateCampaignDates

- **Server group**: `SoftwareManagementV2`
- **Signature**: `UpdateCampaignDates(string account, string campaignId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CampaignSoftware`
- **Error**: `SdkException<UpdateCampaignDatesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CampaignSoftware` | `Models/CampaignSoftware.cs` |
| `UpdateCampaignDatesError` | `Errors/UpdateCampaignDatesError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### UpdateCampaignFirmwareDevices

- **Server group**: `SoftwareManagementV2`
- **Signature**: `UpdateCampaignFirmwareDevices(string account, string campaignId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V2AddOrRemoveDeviceResult`
- **Error**: `SdkException<UpdateCampaignFirmwareDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V2AddOrRemoveDeviceResult` | `Models/V2AddOrRemoveDeviceResult.cs` |
| `UpdateCampaignFirmwareDevicesError` | `Errors/UpdateCampaignFirmwareDevicesError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

