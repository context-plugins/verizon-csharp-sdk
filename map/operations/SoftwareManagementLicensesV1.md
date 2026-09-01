<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementLicensesV1 — operations

Accessor: `client.SoftwareManagementLicensesV1` · Source: `Api/SoftwareManagementLicensesV1.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AssignLicensesToDevices

- **Server group**: `SoftwareManagementV1`
- **Signature**: `AssignLicensesToDevices(string account, V1LicensesAssignedRemovedRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1LicensesAssignedRemovedResult`
- **Error**: `SdkException<AssignLicensesToDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1LicensesAssignedRemovedRequest` | `Models/V1LicensesAssignedRemovedRequest.cs` |
| `V1LicensesAssignedRemovedResult` | `Models/V1LicensesAssignedRemovedResult.cs` |
| `AssignLicensesToDevicesError` | `Errors/AssignLicensesToDevicesError.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

### CreateListOfLicensesToRemove

- **Server group**: `SoftwareManagementV1`
- **Signature**: `CreateListOfLicensesToRemove(string account, V1ListOfLicensesToRemoveRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1ListOfLicensesToRemoveResult`
- **Error**: `SdkException<CreateListOfLicensesToRemoveError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1ListOfLicensesToRemoveRequest` | `Models/V1ListOfLicensesToRemoveRequest.cs` |
| `V1ListOfLicensesToRemoveResult` | `Models/V1ListOfLicensesToRemoveResult.cs` |
| `CreateListOfLicensesToRemoveError` | `Errors/CreateListOfLicensesToRemoveError.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

### DeleteListOfLicensesToRemove

- **Server group**: `SoftwareManagementV1`
- **Signature**: `DeleteListOfLicensesToRemove(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteListOfLicensesToRemoveError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteListOfLicensesToRemoveError` | `Errors/DeleteListOfLicensesToRemoveError.cs` |

### ListLicensesToRemove

- **Server group**: `SoftwareManagementV1`
- **Signature**: `ListLicensesToRemove(string account, string startIndex, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1ListOfLicensesToRemove`
- **Error**: `SdkException<ListLicensesToRemoveError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1ListOfLicensesToRemove` | `Models/V1ListOfLicensesToRemove.cs` |
| `ListLicensesToRemoveError` | `Errors/ListLicensesToRemoveError.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

### RemoveLicensesFromDevices

- **Server group**: `SoftwareManagementV1`
- **Signature**: `RemoveLicensesFromDevices(string account, V1LicensesAssignedRemovedRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1LicensesAssignedRemovedResult`
- **Error**: `SdkException<RemoveLicensesFromDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1LicensesAssignedRemovedRequest` | `Models/V1LicensesAssignedRemovedRequest.cs` |
| `V1LicensesAssignedRemovedResult` | `Models/V1LicensesAssignedRemovedResult.cs` |
| `RemoveLicensesFromDevicesError` | `Errors/RemoveLicensesFromDevicesError.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

