<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceManagement — operations

Accessor: `client.DeviceManagement` · Source: `Api/DeviceManagement.cs` · 29 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateServiceForDevices

- **Signature**: `ActivateServiceForDevices(CarrierActivateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<ActivateServiceForDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CarrierActivateRequest` | `Models/CarrierActivateRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `ActivateServiceForDevicesError` | `Errors/ActivateServiceForDevicesError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### AddDevices

- **Signature**: `AddDevices(AddDevicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<AddDevicesResult>`
- **Error**: `SdkException<AddDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddDevicesRequest` | `Models/AddDevicesRequest.cs` |
| `AddDevicesResult` | `Models/AddDevicesResult.cs` |
| `AddDevicesError` | `Errors/AddDevicesError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### BilledUsageInfo

- **Signature**: `BilledUsageInfo(BilledusageListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<BilledUsageInfoError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BilledusageListRequest` | `Models/BilledusageListRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `BilledUsageInfoError` | `Errors/BilledUsageInfoError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### ChangeDevicesServicePlan

- **Signature**: `ChangeDevicesServicePlan(ServicePlanUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<ChangeDevicesServicePlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ServicePlanUpdateRequest` | `Models/ServicePlanUpdateRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `ChangeDevicesServicePlanError` | `Errors/ChangeDevicesServicePlanError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### CheckDevicesAvailabilityForActivation

- **Signature**: `CheckDevicesAvailabilityForActivation(DeviceActivationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<CheckDevicesAvailabilityForActivationError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceActivationRequest` | `Models/DeviceActivationRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `CheckDevicesAvailabilityForActivationError` | `Errors/CheckDevicesAvailabilityForActivationError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### DeactivateServiceForDevices

- **Signature**: `DeactivateServiceForDevices(CarrierDeactivateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<DeactivateServiceForDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CarrierDeactivateRequest` | `Models/CarrierDeactivateRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `DeactivateServiceForDevicesError` | `Errors/DeactivateServiceForDevicesError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### DeleteDeactivatedDevices

- **Signature**: `DeleteDeactivatedDevices(DeleteDevicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DeleteDevicesResult>`
- **Error**: `SdkException<DeleteDeactivatedDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteDevicesRequest` | `Models/DeleteDevicesRequest.cs` |
| `DeleteDevicesResult` | `Models/DeleteDevicesResult.cs` |
| `DeleteDeactivatedDevicesError` | `Errors/DeleteDeactivatedDevicesError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### DeviceUpload

- **Signature**: `DeviceUpload(DeviceUploadRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RequestResponse`
- **Error**: `SdkException<DeviceUploadError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceUploadRequest` | `Models/DeviceUploadRequest.cs` |
| `RequestResponse` | `Models/RequestResponse.cs` |
| `DeviceUploadError` | `Errors/DeviceUploadError.cs` |
| `RestErrorResponse` | `Models/RestErrorResponse.cs` |

### DeviceUploadStatus

- **Signature**: `DeviceUploadStatus(CheckOrderStatusRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<DeviceUploadStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CheckOrderStatusRequest` | `Models/CheckOrderStatusRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `DeviceUploadStatusError` | `Errors/DeviceUploadStatusError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### GetDeviceExtendedDiagnosticInformation

- **Signature**: `GetDeviceExtendedDiagnosticInformation(DeviceExtendedDiagnosticsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceExtendedDiagnosticsResult`
- **Error**: `SdkException<GetDeviceExtendedDiagnosticInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceExtendedDiagnosticsRequest` | `Models/DeviceExtendedDiagnosticsRequest.cs` |
| `DeviceExtendedDiagnosticsResult` | `Models/DeviceExtendedDiagnosticsResult.cs` |
| `GetDeviceExtendedDiagnosticInformationError` | `Errors/GetDeviceExtendedDiagnosticInformationError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### GetDeviceServiceSuspensionStatus

- **Signature**: `GetDeviceServiceSuspensionStatus(DeviceSuspensionStatusRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<GetDeviceServiceSuspensionStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceSuspensionStatusRequest` | `Models/DeviceSuspensionStatusRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `GetDeviceServiceSuspensionStatusError` | `Errors/GetDeviceServiceSuspensionStatusError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### ListCurrentDevicesPrlVersion

- **Signature**: `ListCurrentDevicesPrlVersion(DevicePrlListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<ListCurrentDevicesPrlVersionError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DevicePrlListRequest` | `Models/DevicePrlListRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `ListCurrentDevicesPrlVersionError` | `Errors/ListCurrentDevicesPrlVersionError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### ListDevicesInformation

- **Signature**: `ListDevicesInformation(AccountDeviceListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AccountDeviceListResult`
- **Error**: `SdkException<ListDevicesInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountDeviceListRequest` | `Models/AccountDeviceListRequest.cs` |
| `AccountDeviceListResult` | `Models/AccountDeviceListResult.cs` |
| `ListDevicesInformationError` | `Errors/ListDevicesInformationError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### ListDevicesProvisioningHistory

- **Signature**: `ListDevicesProvisioningHistory(DeviceProvisioningHistoryListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DeviceProvisioningHistoryListResult>`
- **Error**: `SdkException<ListDevicesProvisioningHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceProvisioningHistoryListRequest` | `Models/DeviceProvisioningHistoryListRequest.cs` |
| `DeviceProvisioningHistoryListResult` | `Models/DeviceProvisioningHistoryListResult.cs` |
| `ListDevicesProvisioningHistoryError` | `Errors/ListDevicesProvisioningHistoryError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### ListDevicesUsageHistory

- **Signature**: `ListDevicesUsageHistory(DeviceUsageListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceUsageListResult`
- **Error**: `SdkException<ListDevicesUsageHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceUsageListRequest` | `Models/DeviceUsageListRequest.cs` |
| `DeviceUsageListResult` | `Models/DeviceUsageListResult.cs` |
| `ListDevicesUsageHistoryError` | `Errors/ListDevicesUsageHistoryError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### ListDevicesWithImeiIccidMismatch

- **Signature**: `ListDevicesWithImeiIccidMismatch(DeviceMismatchListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceMismatchListResult`
- **Error**: `SdkException<ListDevicesWithImeiIccidMismatchError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceMismatchListRequest` | `Models/DeviceMismatchListRequest.cs` |
| `DeviceMismatchListResult` | `Models/DeviceMismatchListResult.cs` |
| `ListDevicesWithImeiIccidMismatchError` | `Errors/ListDevicesWithImeiIccidMismatchError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### MoveDevicesWithinAccountsOfProfile

- **Signature**: `MoveDevicesWithinAccountsOfProfile(MoveDeviceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<MoveDevicesWithinAccountsOfProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MoveDeviceRequest` | `Models/MoveDeviceRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `MoveDevicesWithinAccountsOfProfileError` | `Errors/MoveDevicesWithinAccountsOfProfileError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### RestoreServiceForSuspendedDevices

- **Signature**: `RestoreServiceForSuspendedDevices(CarrierActionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<RestoreServiceForSuspendedDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CarrierActionsRequest` | `Models/CarrierActionsRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `RestoreServiceForSuspendedDevicesError` | `Errors/RestoreServiceForSuspendedDevicesError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### RetrieveAggregateDeviceUsageHistory

- **Signature**: `RetrieveAggregateDeviceUsageHistory(DeviceAggregateUsageListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<RetrieveAggregateDeviceUsageHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceAggregateUsageListRequest` | `Models/DeviceAggregateUsageListRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `RetrieveAggregateDeviceUsageHistoryError` | `Errors/RetrieveAggregateDeviceUsageHistoryError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### RetrieveDeviceConnectionHistory

- **Signature**: `RetrieveDeviceConnectionHistory(DeviceConnectionListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ConnectionHistoryResult`
- **Error**: `SdkException<RetrieveDeviceConnectionHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceConnectionListRequest` | `Models/DeviceConnectionListRequest.cs` |
| `ConnectionHistoryResult` | `Models/ConnectionHistoryResult.cs` |
| `RetrieveDeviceConnectionHistoryError` | `Errors/RetrieveDeviceConnectionHistoryError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### SuspendServiceForDevices

- **Signature**: `SuspendServiceForDevices(CarrierActionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<SuspendServiceForDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CarrierActionsRequest` | `Models/CarrierActionsRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `SuspendServiceForDevicesError` | `Errors/SuspendServiceForDevicesError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### UpdateDeviceId

- **Signature**: `UpdateDeviceId(string serviceType, ChangeDeviceIdRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<UpdateDeviceIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChangeDeviceIdRequest` | `Models/ChangeDeviceIdRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `UpdateDeviceIdError` | `Errors/UpdateDeviceIdError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### UpdateDevicesContactInformation

- **Signature**: `UpdateDevicesContactInformation(ContactInfoUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<UpdateDevicesContactInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ContactInfoUpdateRequest` | `Models/ContactInfoUpdateRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `UpdateDevicesContactInformationError` | `Errors/UpdateDevicesContactInformationError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### UpdateDevicesCostCenterCode

- **Signature**: `UpdateDevicesCostCenterCode(DeviceCostCenterRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<UpdateDevicesCostCenterCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceCostCenterRequest` | `Models/DeviceCostCenterRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `UpdateDevicesCostCenterCodeError` | `Errors/UpdateDevicesCostCenterCodeError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### UpdateDevicesCustomFields

- **Signature**: `UpdateDevicesCustomFields(CustomFieldsUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<UpdateDevicesCustomFieldsError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CustomFieldsUpdateRequest` | `Models/CustomFieldsUpdateRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `UpdateDevicesCustomFieldsError` | `Errors/UpdateDevicesCustomFieldsError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### UpdateDevicesState

- **Signature**: `UpdateDevicesState(GoToStateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<UpdateDevicesStateError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GoToStateRequest` | `Models/GoToStateRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `UpdateDevicesStateError` | `Errors/UpdateDevicesStateError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### UploadActivateDevice

- **Signature**: `UploadActivateDevice(UploadsActivatesDeviceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<UploadActivateDeviceError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UploadsActivatesDeviceRequest` | `Models/UploadsActivatesDeviceRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `UploadActivateDeviceError` | `Errors/UploadActivateDeviceError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### UsageSegmentationLabelAssociation

- **Signature**: `UsageSegmentationLabelAssociation(AssociateLabelRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<UsageSegmentationLabelAssociationError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AssociateLabelRequest` | `Models/AssociateLabelRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `UsageSegmentationLabelAssociationError` | `Errors/UsageSegmentationLabelAssociationError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### UsageSegmentationLabelDeletion

- **Signature**: `UsageSegmentationLabelDeletion(string accountName, LabelsList labelList, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `accountName` ← `accountName`, `LabelList` ← `labelList`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<UsageSegmentationLabelDeletionError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LabelsList` | `Models/LabelsList.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `UsageSegmentationLabelDeletionError` | `Errors/UsageSegmentationLabelDeletionError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

