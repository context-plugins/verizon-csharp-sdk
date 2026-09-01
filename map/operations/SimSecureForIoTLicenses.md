<!-- Generated file — do not edit; regenerated with the SDK. -->

# SimSecureForIoTLicenses — operations

Accessor: `client.SimSecureForIoTLicenses` · Source: `Api/SimSecureForIoTLicenses.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AssignLicenseToDevices

- **Server group**: `M2M`
- **Signature**: `AssignLicenseToDevices(string? xRequestId, AssignLicenseRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `xRequestId` — nullable, no default → **must pass explicitly**
- **Returns**: `SecuritySuccessResult`
- **Error**: `SdkException<AssignLicenseToDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetSecurityResult(out SecurityResult)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AssignLicenseRequest` | `Models/AssignLicenseRequest.cs` |
| `SecuritySuccessResult` | `Models/SecuritySuccessResult.cs` |
| `AssignLicenseToDevicesError` | `Errors/AssignLicenseToDevicesError.cs` |
| `SecurityResult` | `Models/SecurityResult.cs` |

### UnassignLicenseToDevices

- **Server group**: `M2M`
- **Signature**: `UnassignLicenseToDevices(string xRequestId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SecuritySuccessResult`
- **Error**: `SdkException<UnassignLicenseToDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetSecurityResult(out SecurityResult)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SecuritySuccessResult` | `Models/SecuritySuccessResult.cs` |
| `UnassignLicenseToDevicesError` | `Errors/UnassignLicenseToDevicesError.cs` |
| `SecurityResult` | `Models/SecurityResult.cs` |

