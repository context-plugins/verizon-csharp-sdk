<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementSubscriptionsV2 — operations

Accessor: `client.SoftwareManagementSubscriptionsV2` · Source: `Api/SoftwareManagementSubscriptionsV2.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountSubscriptionStatus2

- **Server group**: `SoftwareManagementV2`
- **Signature**: `GetAccountSubscriptionStatus2(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FotaV2Subscription`
- **Error**: `SdkException<GetAccountSubscriptionStatus2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FotaV2Subscription` | `Models/FotaV2Subscription.cs` |
| `GetAccountSubscriptionStatus2Error` | `Errors/GetAccountSubscriptionStatus2Error.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

