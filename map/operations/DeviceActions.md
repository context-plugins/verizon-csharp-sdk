<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceActions — operations

Accessor: `client.DeviceActions` · Source: `Api/DeviceActions.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AccountInformation

- **Signature**: `AccountInformation(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AccountDetails`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccountDetails` | `Models/AccountDetails.cs` |

### AggregateUsage

- **Signature**: `AggregateUsage(AggregateUsage body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GioRequestResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AggregateUsage` | `Models/AggregateUsage.cs` |
| `GioRequestResponse` | `Models/GioRequestResponse.cs` |

### DailyUsage

- **Signature**: `DailyUsage(DailyUsage body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DailyUsageResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DailyUsage` | `Models/DailyUsage.cs` |
| `DailyUsageResponse` | `Models/DailyUsageResponse.cs` |

### GetAsynchronousRequestStatus

- **Signature**: `GetAsynchronousRequestStatus(string accountName, string requestId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `StatusResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StatusResponse` | `Models/StatusResponse.cs` |

### RetrieveDeviceProvisioningHistory

- **Signature**: `RetrieveDeviceProvisioningHistory(ProvhistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GioRequestResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProvhistoryRequest` | `Models/ProvhistoryRequest.cs` |
| `GioRequestResponse` | `Models/GioRequestResponse.cs` |

### RetrieveTheGlobalDeviceList

- **Signature**: `RetrieveTheGlobalDeviceList(GetDeviceListWithProfilesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GioRequestResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetDeviceListWithProfilesRequest` | `Models/GetDeviceListWithProfilesRequest.cs` |
| `GioRequestResponse` | `Models/GioRequestResponse.cs` |

### ServicePlanList

- **Signature**: `ServicePlanList(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AccountDetails`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccountDetails` | `Models/AccountDetails.cs` |

