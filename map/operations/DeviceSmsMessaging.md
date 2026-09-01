<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceSmsMessaging — operations

Accessor: `client.DeviceSmsMessaging` · Source: `Api/DeviceSmsMessaging.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetSmsMessages

- **Signature**: `GetSmsMessages(string accountName, string? next, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `next` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `next` ← `next`
- **Returns**: `SmsMessagesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SmsMessagesResponse` | `Models/SmsMessagesResponse.cs` |

### ListSmsMessageHistory

- **Signature**: `ListSmsMessageHistory(SmsEventHistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GioRequestResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SmsEventHistoryRequest` | `Models/SmsEventHistoryRequest.cs` |
| `GioRequestResponse` | `Models/GioRequestResponse.cs` |

### SendAnSmsMessage

- **Signature**: `SendAnSmsMessage(GiosmsSendRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GioRequestResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GiosmsSendRequest` | `Models/GiosmsSendRequest.cs` |
| `GioRequestResponse` | `Models/GioRequestResponse.cs` |

### StartSmsMessageDelivery

- **Signature**: `StartSmsMessageDelivery(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SuccessResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SuccessResponse` | `Models/SuccessResponse.cs` |

