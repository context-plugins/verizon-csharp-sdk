<!-- Generated file — do not edit; regenerated with the SDK. -->

# IntelligenceServiceController — operations

Accessor: `client.IntelligenceServiceController` · Source: `Api/IntelligenceServiceController.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SetConnectionPlanner

- **Signature**: `SetConnectionPlanner(GetDevicesWindowsRequestforplanner? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AsynchronousRequestResultforplanner`
- **Error**: `SdkException<SetConnectionPlannerError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponseforplanner(out RestErrorResponseforplanner)` [400, 403, 404, 406, 429] · `TryGetAuthRestErrorResponseforplanner(out AuthRestErrorResponseforplanner)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDevicesWindowsRequestforplanner` | `Models/GetDevicesWindowsRequestforplanner.cs` |
| `AsynchronousRequestResultforplanner` | `Models/AsynchronousRequestResultforplanner.cs` |
| `SetConnectionPlannerError` | `Errors/SetConnectionPlannerError.cs` |
| `RestErrorResponseforplanner` | `Models/RestErrorResponseforplanner.cs` |
| `AuthRestErrorResponseforplanner` | `Models/AuthRestErrorResponseforplanner.cs` |

### StatusConnectionPlanner

- **Signature**: `StatusConnectionPlanner(GetDeviceStatusesRequestforplanner? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `GetDeviceStatusesResponseforplanner`
- **Error**: `SdkException<StatusConnectionPlannerError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponseforplanner(out RestErrorResponseforplanner)` [400, 403, 404, 406, 429] · `TryGetAuthRestErrorResponseforplanner(out AuthRestErrorResponseforplanner)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDeviceStatusesRequestforplanner` | `Models/GetDeviceStatusesRequestforplanner.cs` |
| `GetDeviceStatusesResponseforplanner` | `Models/GetDeviceStatusesResponseforplanner.cs` |
| `StatusConnectionPlannerError` | `Errors/StatusConnectionPlannerError.cs` |
| `RestErrorResponseforplanner` | `Models/RestErrorResponseforplanner.cs` |
| `AuthRestErrorResponseforplanner` | `Models/AuthRestErrorResponseforplanner.cs` |

