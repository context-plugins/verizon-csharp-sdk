<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementSubscriptionsV3 — operations

Accessor: `client.SoftwareManagementSubscriptionsV3` · Source: `Api/SoftwareManagementSubscriptionsV3.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountSubscriptionStatus3

- **Server group**: `SoftwareManagementV3`
- **Signature**: `GetAccountSubscriptionStatus3(string acc, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FotaV3Subscription`
- **Error**: `SdkException<GetAccountSubscriptionStatus3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FotaV3Subscription` | `Models/FotaV3Subscription.cs` |
| `GetAccountSubscriptionStatus3Error` | `Errors/GetAccountSubscriptionStatus3Error.cs` |
| `FotaV3Result` | `Models/FotaV3Result.cs` |

