<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementLicensesV3 — operations

Accessor: `client.SoftwareManagementLicensesV3` · Source: `Api/SoftwareManagementLicensesV3.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AssignLicensesToDevices3

- **Server group**: `SoftwareManagementV3`
- **Signature**: `AssignLicensesToDevices3(string acc, V3LicenseImei body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V3LicenseAssignedRemovedResult`
- **Error**: `SdkException<AssignLicensesToDevices3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V3LicenseImei` | `Models/V3LicenseImei.cs` |
| `V3LicenseAssignedRemovedResult` | `Models/V3LicenseAssignedRemovedResult.cs` |
| `AssignLicensesToDevices3Error` | `Errors/AssignLicensesToDevices3Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

### GetAccountLicensesStatus

- **Server group**: `SoftwareManagementV3`
- **Signature**: `GetAccountLicensesStatus(string acc, string? lastSeenDeviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `lastSeenDeviceId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `lastSeenDeviceId` ← `lastSeenDeviceId`
- **Returns**: `V3LicenseSummary`
- **Error**: `SdkException<GetAccountLicensesStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V3LicenseSummary` | `Models/V3LicenseSummary.cs` |
| `GetAccountLicensesStatusError` | `Errors/GetAccountLicensesStatusError.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

### RemoveLicensesFromDevices3

- **Server group**: `SoftwareManagementV3`
- **Signature**: `RemoveLicensesFromDevices3(string acc, V3LicenseImei body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V3LicenseAssignedRemovedResult`
- **Error**: `SdkException<RemoveLicensesFromDevices3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V3LicenseImei` | `Models/V3LicenseImei.cs` |
| `V3LicenseAssignedRemovedResult` | `Models/V3LicenseAssignedRemovedResult.cs` |
| `RemoveLicensesFromDevices3Error` | `Errors/RemoveLicensesFromDevices3Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

