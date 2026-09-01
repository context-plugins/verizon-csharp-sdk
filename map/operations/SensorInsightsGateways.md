<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsGateways — operations

Accessor: `client.SensorInsightsGateways` · Source: `Api/SensorInsightsGateways.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsListGatewayDevicesRequest

- **Signature**: `SensorInsightsListGatewayDevicesRequest(DtoListDevicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<ResourceDevice>`
- **Error**: `SdkException<SensorInsightsListGatewayDevicesRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoListDevicesRequest` | `Models/DtoListDevicesRequest.cs` |
| `ResourceDevice` | `Models/ResourceDevice.cs` |
| `SensorInsightsListGatewayDevicesRequestError` | `Errors/SensorInsightsListGatewayDevicesRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

