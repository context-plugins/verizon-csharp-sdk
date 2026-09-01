<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementLicensesV2 — operations

Accessor: `client.SoftwareManagementLicensesV2` · Source: `Api/SoftwareManagementLicensesV2.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AssignLicensesToDevices2

- **Server group**: `SoftwareManagementV2`
- **Signature**: `AssignLicensesToDevices2(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V2LicensesAssignedRemovedResult`
- **Error**: `SdkException<AssignLicensesToDevices2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V2LicensesAssignedRemovedResult` | `Models/V2LicensesAssignedRemovedResult.cs` |
| `AssignLicensesToDevices2Error` | `Errors/AssignLicensesToDevices2Error.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### CreateListOfLicensesToRemove2

- **Server group**: `SoftwareManagementV2`
- **Signature**: `CreateListOfLicensesToRemove2(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V2ListOfLicensesToRemoveResult`
- **Error**: `SdkException<CreateListOfLicensesToRemove2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V2ListOfLicensesToRemoveResult` | `Models/V2ListOfLicensesToRemoveResult.cs` |
| `CreateListOfLicensesToRemove2Error` | `Errors/CreateListOfLicensesToRemove2Error.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### DeleteListOfLicensesToRemove2

- **Server group**: `SoftwareManagementV2`
- **Signature**: `DeleteListOfLicensesToRemove2(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FotaV2SuccessResult`
- **Error**: `SdkException<DeleteListOfLicensesToRemove2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FotaV2SuccessResult` | `Models/FotaV2SuccessResult.cs` |
| `DeleteListOfLicensesToRemove2Error` | `Errors/DeleteListOfLicensesToRemove2Error.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### GetAccountLicenseStatus2

- **Server group**: `SoftwareManagementV2`
- **Signature**: `GetAccountLicenseStatus2(string account, string? lastSeenDeviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `lastSeenDeviceId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `lastSeenDeviceId` ← `lastSeenDeviceId`
- **Returns**: `V2LicenseSummary`
- **Error**: `SdkException<GetAccountLicenseStatus2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V2LicenseSummary` | `Models/V2LicenseSummary.cs` |
| `GetAccountLicenseStatus2Error` | `Errors/GetAccountLicenseStatus2Error.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### ListLicensesToRemove2

- **Server group**: `SoftwareManagementV2`
- **Signature**: `ListLicensesToRemove2(string account, string? startIndex, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `startIndex` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `startIndex` ← `startIndex`
- **Returns**: `V2ListOfLicensesToRemove`
- **Error**: `SdkException<ListLicensesToRemove2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V2ListOfLicensesToRemove` | `Models/V2ListOfLicensesToRemove.cs` |
| `ListLicensesToRemove2Error` | `Errors/ListLicensesToRemove2Error.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### RemoveLicensesFromDevices2

- **Server group**: `SoftwareManagementV2`
- **Signature**: `RemoveLicensesFromDevices2(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V2LicensesAssignedRemovedResult`
- **Error**: `SdkException<RemoveLicensesFromDevices2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V2LicensesAssignedRemovedResult` | `Models/V2LicensesAssignedRemovedResult.cs` |
| `RemoveLicensesFromDevices2Error` | `Errors/RemoveLicensesFromDevices2Error.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

