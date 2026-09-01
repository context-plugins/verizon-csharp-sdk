<!-- Generated file — do not edit; regenerated with the SDK. -->

# HplDeviceManagement — operations

Accessor: `client.HplDeviceManagement` · Source: `Api/HplDeviceManagement.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddDevicesHyperPrecise

- **Server group**: `HyperPreciseLocation`
- **Signature**: `AddDevicesHyperPrecise(HplAddDevicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<HplAddDevicesRequest>`
- **Error**: `SdkException<AddDevicesHyperPreciseError>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 405, 406, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `HplAddDevicesRequest` | `Models/HplAddDevicesRequest.cs` |
| `AddDevicesHyperPreciseError` | `Errors/AddDevicesHyperPreciseError.cs` |
| `HyperPreciseLocationResult` | `Models/HyperPreciseLocationResult.cs` |

