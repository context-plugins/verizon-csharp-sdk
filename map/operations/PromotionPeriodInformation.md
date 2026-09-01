<!-- Generated file — do not edit; regenerated with the SDK. -->

# PromotionPeriodInformation — operations

Accessor: `client.PromotionPeriodInformation` · Source: `Api/PromotionPeriodInformation.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPromoDeviceAggregateUsageHistory

- **Signature**: `GetPromoDeviceAggregateUsageHistory(RequestBodyForUsage body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UsageRequestResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RequestBodyForUsage` | `Models/RequestBodyForUsage.cs` |
| `UsageRequestResponse` | `Models/UsageRequestResponse.cs` |

### GetPromoDeviceUsageHistory

- **Signature**: `GetPromoDeviceUsageHistory(ARequestBodyForUsage body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ResponseToUsageQuery`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ARequestBodyForUsage` | `Models/ARequestBodyForUsage.cs` |
| `ResponseToUsageQuery` | `Models/ResponseToUsageQuery.cs` |

