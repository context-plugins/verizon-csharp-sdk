<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountSubscriptions — operations

Accessor: `client.AccountSubscriptions` · Source: `Api/AccountSubscriptions.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListAccountSubscriptions

- **Server group**: `M2M`
- **Signature**: `ListAccountSubscriptions(string? xRequestId, SecuritySubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `xRequestId` — nullable, no default → **must pass explicitly**
- **Returns**: `SecuritySubscriptionResult`
- **Error**: `SdkException<ListAccountSubscriptionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetSecurityResult(out SecurityResult)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SecuritySubscriptionRequest` | `Models/SecuritySubscriptionRequest.cs` |
| `SecuritySubscriptionResult` | `Models/SecuritySubscriptionResult.cs` |
| `ListAccountSubscriptionsError` | `Errors/ListAccountSubscriptionsError.cs` |
| `SecurityResult` | `Models/SecurityResult.cs` |

