<!-- Generated file — do not edit; regenerated with the SDK. -->

# CampaignsV3 — operations

Accessor: `client.CampaignsV3` · Source: `Api/CampaignsV3.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelCampaign2

- **Server group**: `SoftwareManagementV3`
- **Signature**: `CancelCampaign2(string accountName, string campaignId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FotaV3SuccessResult`
- **Error**: `SdkException<CancelCampaign2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FotaV3SuccessResult` | `Models/FotaV3SuccessResult.cs` |
| `CancelCampaign2Error` | `Errors/CancelCampaign2Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

### GetCampaignInformation2

- **Server group**: `SoftwareManagementV3`
- **Signature**: `GetCampaignInformation2(string accountName, string campaignId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Campaign`
- **Error**: `SdkException<GetCampaignInformation2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Campaign` | `Models/Campaign.cs` |
| `GetCampaignInformation2Error` | `Errors/GetCampaignInformation2Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

### ScheduleCampaignFirmwareUpgrade2

- **Server group**: `SoftwareManagementV3`
- **Signature**: `ScheduleCampaignFirmwareUpgrade2(string accountName, CampaignFirmwareUpgrade body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FirmwareCampaign`
- **Error**: `SdkException<ScheduleCampaignFirmwareUpgrade2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CampaignFirmwareUpgrade` | `Models/CampaignFirmwareUpgrade.cs` |
| `FirmwareCampaign` | `Models/FirmwareCampaign.cs` |
| `ScheduleCampaignFirmwareUpgrade2Error` | `Errors/ScheduleCampaignFirmwareUpgrade2Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

### UpdateCampaignDates2

- **Server group**: `SoftwareManagementV3`
- **Signature**: `UpdateCampaignDates2(string acc, string campaignId, V3ChangeCampaignDatesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FirmwareCampaign`
- **Error**: `SdkException<UpdateCampaignDates2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V3ChangeCampaignDatesRequest` | `Models/V3ChangeCampaignDatesRequest.cs` |
| `FirmwareCampaign` | `Models/FirmwareCampaign.cs` |
| `UpdateCampaignDates2Error` | `Errors/UpdateCampaignDates2Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

### UpdateCampaignFirmwareDevices2

- **Server group**: `SoftwareManagementV3`
- **Signature**: `UpdateCampaignFirmwareDevices2(string acc, string campaignId, V3AddOrRemoveDeviceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V3AddOrRemoveDeviceResult`
- **Error**: `SdkException<UpdateCampaignFirmwareDevices2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V3AddOrRemoveDeviceRequest` | `Models/V3AddOrRemoveDeviceRequest.cs` |
| `V3AddOrRemoveDeviceResult` | `Models/V3AddOrRemoveDeviceResult.cs` |
| `UpdateCampaignFirmwareDevices2Error` | `Errors/UpdateCampaignFirmwareDevices2Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

