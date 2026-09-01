<!-- Generated file — do not edit; regenerated with the SDK. -->

# ThingSpaceQualityOfServiceApiActions — operations

Accessor: `client.ThingSpaceQualityOfServiceApiActions` · Source: `Api/ThingSpaceQualityOfServiceApiActions.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAThingSpaceQualityOfServiceApiSubscription

- **Signature**: `CreateAThingSpaceQualityOfServiceApiSubscription(SubscribeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Success201`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SubscribeRequest` | `Models/SubscribeRequest.cs` |
| `Success201` | `Models/Success201.cs` |

### StopAThingSpaceQualityOfServiceApiSubscription

- **Signature**: `StopAThingSpaceQualityOfServiceApiSubscription(string accountName, string qosSubscriptionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `accountName` ← `accountName`, `qosSubscriptionId` ← `qosSubscriptionId`
- **Returns**: `Success201`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Success201` | `Models/Success201.cs` |

