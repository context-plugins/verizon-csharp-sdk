<!-- Generated file — do not edit; regenerated with the SDK. -->

# Sms — operations

Accessor: `client.Sms` · Source: `Api/Sms.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListDevicesSmsMessages

- **Signature**: `ListDevicesSmsMessages(string aname, long? next, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `next` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `next` ← `next`
- **Returns**: `SmsMessagesQueryResult`
- **Error**: `SdkException<ListDevicesSmsMessagesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SmsMessagesQueryResult` | `Models/SmsMessagesQueryResult.cs` |
| `ListDevicesSmsMessagesError` | `Errors/ListDevicesSmsMessagesError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### SendSmsToDevice

- **Signature**: `SendSmsToDevice(SmsSendRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<SendSmsToDeviceError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SmsSendRequest` | `Models/SmsSendRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `SendSmsToDeviceError` | `Errors/SendSmsToDeviceError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### StartQueuedSmsDelivery

- **Signature**: `StartQueuedSmsDelivery(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ConnectivityManagementSuccessResult`
- **Error**: `SdkException<StartQueuedSmsDeliveryError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ConnectivityManagementSuccessResult` | `Models/ConnectivityManagementSuccessResult.cs` |
| `StartQueuedSmsDeliveryError` | `Errors/StartQueuedSmsDeliveryError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

