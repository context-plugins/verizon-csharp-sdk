<!-- Generated file — do not edit; regenerated with the SDK. -->

# CloudConnectorDevices — operations

Accessor: `client.CloudConnectorDevices` · Source: `Api/CloudConnectorDevices.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteDeviceFromAccount

- **Server group**: `CloudConnector`
- **Signature**: `DeleteDeviceFromAccount(RemoveDeviceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemoveDeviceRequest` | `Models/RemoveDeviceRequest.cs` |

### FindDeviceByPropertyValues

- **Server group**: `CloudConnector`
- **Signature**: `FindDeviceByPropertyValues(QuerySubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FindDeviceByPropertyResponseList`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `QuerySubscriptionRequest` | `Models/QuerySubscriptionRequest.cs` |
| `FindDeviceByPropertyResponseList` | `Models/FindDeviceByPropertyResponseList.cs` |

### SearchDeviceEventHistory

- **Server group**: `CloudConnector`
- **Signature**: `SearchDeviceEventHistory(SearchDeviceEventHistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchDeviceEventHistoryResponseList`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchDeviceEventHistoryRequest` | `Models/SearchDeviceEventHistoryRequest.cs` |
| `SearchDeviceEventHistoryResponseList` | `Models/SearchDeviceEventHistoryResponseList.cs` |

### SearchDevicesResourcesByPropertyValues

- **Server group**: `CloudConnector`
- **Signature**: `SearchDevicesResourcesByPropertyValues(QuerySubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchDeviceByPropertyResponseList`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `QuerySubscriptionRequest` | `Models/QuerySubscriptionRequest.cs` |
| `SearchDeviceByPropertyResponseList` | `Models/SearchDeviceByPropertyResponseList.cs` |

### SearchSensorReadings

- **Server group**: `CloudConnector`
- **Signature**: `SearchSensorReadings(string fieldname, SearchSensorHistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchSensorHistoryResponseList`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchSensorHistoryRequest` | `Models/SearchSensorHistoryRequest.cs` |
| `SearchSensorHistoryResponseList` | `Models/SearchSensorHistoryResponseList.cs` |

### UpdateDevicesConfigurationValue

- **Server group**: `CloudConnector`
- **Signature**: `UpdateDevicesConfigurationValue(ChangeConfigurationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ChangeConfigurationResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChangeConfigurationRequest` | `Models/ChangeConfigurationRequest.cs` |
| `ChangeConfigurationResponse` | `Models/ChangeConfigurationResponse.cs` |

