<!-- Generated file — do not edit; regenerated with the SDK. -->

# Exclusions — operations

Accessor: `client.Exclusions` · Source: `Api/Exclusions.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DevicesLocationGetConsentAsync

- **Server group**: `DeviceLocation`
- **Signature**: `DevicesLocationGetConsentAsync(string accountName, string? deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `deviceId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `accountName` ← `accountName`, `deviceId` ← `deviceId`
- **Returns**: `GetAccountDeviceConsent`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetAccountDeviceConsent` | `Models/GetAccountDeviceConsent.cs` |

### DevicesLocationGiveConsentAsync

- **Server group**: `DeviceLocation`
- **Signature**: `DevicesLocationGiveConsentAsync(AccountConsentCreate? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ConsentTransactionId`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccountConsentCreate` | `Models/AccountConsentCreate.cs` |
| `ConsentTransactionId` | `Models/ConsentTransactionId.cs` |

### DevicesLocationUpdateConsent

- **Server group**: `DeviceLocation`
- **Signature**: `DevicesLocationUpdateConsent(AccountConsentUpdate? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ConsentTransactionId`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccountConsentUpdate` | `Models/AccountConsentUpdate.cs` |
| `ConsentTransactionId` | `Models/ConsentTransactionId.cs` |

### ExcludeDevices

- **Server group**: `DeviceLocation`
- **Signature**: `ExcludeDevices(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceLocationSuccessResult`
- **Error**: `SdkException<ExcludeDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceLocationSuccessResult` | `Models/DeviceLocationSuccessResult.cs` |
| `ExcludeDevicesError` | `Errors/ExcludeDevicesError.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

### ListExcludedDevices

- **Server group**: `DeviceLocation`
- **Signature**: `ListExcludedDevices(string accountName, string startIndex, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DevicesConsentResult`
- **Error**: `SdkException<ListExcludedDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DevicesConsentResult` | `Models/DevicesConsentResult.cs` |
| `ListExcludedDevicesError` | `Errors/ListExcludedDevicesError.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

### RemoveDevicesFromExclusionList

- **Server group**: `DeviceLocation`
- **Signature**: `RemoveDevicesFromExclusionList(string accountName, string deviceList, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `accountName` ← `accountName`, `deviceList` ← `deviceList`
- **Returns**: `DeviceLocationSuccessResult`
- **Error**: `SdkException<RemoveDevicesFromExclusionListError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceLocationSuccessResult` | `Models/DeviceLocationSuccessResult.cs` |
| `RemoveDevicesFromExclusionListError` | `Errors/RemoveDevicesFromExclusionListError.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

