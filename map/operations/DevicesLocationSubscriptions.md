<!-- Generated file — do not edit; regenerated with the SDK. -->

# DevicesLocationSubscriptions — operations

Accessor: `client.DevicesLocationSubscriptions` · Source: `Api/DevicesLocationSubscriptions.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetLocationServiceSubscriptionStatus

- **Server group**: `DeviceLocation`
- **Signature**: `GetLocationServiceSubscriptionStatus(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceLocationSubscription`
- **Error**: `SdkException<GetLocationServiceSubscriptionStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceLocationSubscription` | `Models/DeviceLocationSubscription.cs` |
| `GetLocationServiceSubscriptionStatusError` | `Errors/GetLocationServiceSubscriptionStatusError.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

### GetLocationServiceUsage

- **Server group**: `DeviceLocation`
- **Signature**: `GetLocationServiceUsage(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `object`
- **Error**: `SdkException<GetLocationServiceUsageError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLocationServiceUsageError` | `Errors/GetLocationServiceUsageError.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

