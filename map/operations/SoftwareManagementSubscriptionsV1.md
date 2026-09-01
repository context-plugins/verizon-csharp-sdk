<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementSubscriptionsV1 — operations

Accessor: `client.SoftwareManagementSubscriptionsV1` · Source: `Api/SoftwareManagementSubscriptionsV1.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountLicenseStatus

- **Server group**: `SoftwareManagementV1`
- **Signature**: `GetAccountLicenseStatus(string account, string startIndex, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AccountLicenseInfo`
- **Error**: `SdkException<GetAccountLicenseStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountLicenseInfo` | `Models/AccountLicenseInfo.cs` |
| `GetAccountLicenseStatusError` | `Errors/GetAccountLicenseStatusError.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

### GetAccountSubscriptionStatus

- **Server group**: `SoftwareManagementV1`
- **Signature**: `GetAccountSubscriptionStatus(string account, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1AccountSubscription`
- **Error**: `SdkException<GetAccountSubscriptionStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1AccountSubscription` | `Models/V1AccountSubscription.cs` |
| `GetAccountSubscriptionStatusError` | `Errors/GetAccountSubscriptionStatusError.cs` |
| `FotaV1Result` | `Models/FotaV1Result.cs` |

