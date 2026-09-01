<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceServiceManagement — operations

Accessor: `client.DeviceServiceManagement` · Source: `Api/DeviceServiceManagement.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDeviceHyperPreciseStatus

- **Server group**: `HyperPreciseLocation`
- **Signature**: `GetDeviceHyperPreciseStatus(string imei, string accountNumber, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `imei` ← `imei`, `accountNumber` ← `accountNumber`
- **Returns**: `BullseyeServiceResult`
- **Error**: `SdkException<GetDeviceHyperPreciseStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BullseyeServiceResult` | `Models/BullseyeServiceResult.cs` |
| `GetDeviceHyperPreciseStatusError` | `Errors/GetDeviceHyperPreciseStatusError.cs` |
| `HyperPreciseLocationResult` | `Models/HyperPreciseLocationResult.cs` |

### UpdateDeviceHyperPreciseStatus

- **Server group**: `HyperPreciseLocation`
- **Signature**: `UpdateDeviceHyperPreciseStatus(BullseyeServiceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BullseyeServiceResult`
- **Error**: `SdkException<UpdateDeviceHyperPreciseStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BullseyeServiceRequest` | `Models/BullseyeServiceRequest.cs` |
| `BullseyeServiceResult` | `Models/BullseyeServiceResult.cs` |
| `UpdateDeviceHyperPreciseStatusError` | `Errors/UpdateDeviceHyperPreciseStatusError.cs` |
| `HyperPreciseLocationResult` | `Models/HyperPreciseLocationResult.cs` |

